using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data.Services;
using ShortUrl.Utils;
using WebApplication1.Utils;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceAsync<Url> urlService;

        public HomeController(IServiceAsync<Url> urlService)
        {
            this.urlService = urlService;
        }
        public async Task<IActionResult> Index()
        {
            var urls = await urlService.GetAllAsync();
            ViewData["Host"] = Constants.host;
            return View(urls);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string fullUrl)
        {
            MakeShortUrl shortUrl = new MakeShortUrl(fullUrl + DateTime.Now.ToString());
            await urlService.AddAsync(new Url(shortUrl.ToString(), fullUrl, DateTime.Now, 0));
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await urlService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet("{shortUrl}")]
        public async Task<IActionResult> GetRedirect([FromRoute]string shortUrl)
        {
            Url url = await urlService.GetUrlAsync(shortUrl);
            url.Count++;
            await urlService.UpdateAsync(url);
            return Redirect(url.FullUrl);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
