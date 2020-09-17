using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.Common.Domain.Services
{
    public abstract class BaseService<TKey, T> : IBaseService<TKey, T>
    {
        private readonly IRepository<TKey, T> _repository;

        protected BaseService(IRepository<TKey, T> repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(T entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task DeleteAsync(TKey id)
        {
            await _repository.DeleteAsync(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _repository.ReadAll();
        }

        public async Task<IEnumerable<T>> ReadAllAsync()
        {
            return await _repository.ReadAllAsync();
        }

        public async Task<T> ReadAsync(TKey id)
        {
            return await _repository.ReadAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _repository.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
