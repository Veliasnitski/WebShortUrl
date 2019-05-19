using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Services
{
    public interface IServiceAsync<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetUrlAsync(string id);
        Task AddAsync(T el);
        Task DeleteAsync(string id);
        Task UpdateAsync(T el);
    }
}
