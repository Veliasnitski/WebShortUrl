using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace WebApplication1.Data.Repositories
{
    public interface IRepositoryAsync<T> 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetUrlAsync(string id);
        Task AddAsync(T el);
        Task DeleteAsync(string id);

        Task UpdateAsync(T el);
    }
}
