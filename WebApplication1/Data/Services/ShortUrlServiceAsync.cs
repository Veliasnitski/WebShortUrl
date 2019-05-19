using WebApplication1.Data.Repositories;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Services
{
    public class ShortUrlServiceAsync : IServiceAsync<Url>
    {
        private readonly IRepositoryAsync<Url> urlRepository;

        public ShortUrlServiceAsync(IRepositoryAsync<Url> urlRepository)
        {
            this.urlRepository = urlRepository;
        }

        public async Task<IEnumerable<Url>> GetAllAsync()
        {
            return await urlRepository.GetAllAsync();
        }

        public async Task AddAsync(Url el)
        {
            await urlRepository.AddAsync(el);
        }

        public async Task DeleteAsync(string id)
        {
            await urlRepository.DeleteAsync(id);
        }

        public async Task<Url> GetUrlAsync(string id)
        {
            return await urlRepository.GetUrlAsync(id);
        }

        public async Task UpdateAsync(Url el)
        {
            await urlRepository.UpdateAsync(el);
        }
    }
}
