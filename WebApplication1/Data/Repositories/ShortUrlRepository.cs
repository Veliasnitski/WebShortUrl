using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Repositories
{
    public class ShortUrlRepository : IRepositoryAsync<Url>
    {
        private readonly ShortUrlContext dbContext;

        public ShortUrlRepository(ShortUrlContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(Url el)
        {
            dbContext.Add(el);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            Url url = dbContext.Urls.Find(id);
            if (url != null) dbContext.Urls.Remove(url);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Url>> GetAllAsync()
        {
            return await dbContext.Set<Url>().OrderByDescending(s => s.DateCreate).ToListAsync();
        }

        public async Task<Url> GetUrlAsync(string id)
        {
            return await dbContext.Urls.FindAsync(id);
        }

        public async Task UpdateAsync(Url el)
        {
            dbContext.Entry(el).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }
    }
}
