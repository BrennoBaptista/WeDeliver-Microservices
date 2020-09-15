using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeDeliver.Common.Domain.Repositories
{
    public interface IRepository<TKey, T>
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(TKey id);
        void Update(T entity);
        Task<T> ReadAsync(TKey id);
        IEnumerable<T> ReadAll();
        Task<IEnumerable<T>> ReadAllAsync();
        Task<int> SaveChangesAsync();
    }
}
