using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    public class RastreioService : IRastreioService
    {
        private IRastreioRepository _rastreioRepository;

        public RastreioService(IRastreioRepository rastreioRepository)
        {
            _rastreioRepository = rastreioRepository;
        }

        public async Task CreateAsync(Rastreio entity)
        {
            await _rastreioRepository.CreateAsync(entity);
        }

        public IEnumerable<Rastreio> ReadAll()
        {
            return _rastreioRepository.ReadAll();
        }

        public async Task<IEnumerable<Rastreio>> ReadAllAsync()
        {
            return await _rastreioRepository.ReadAllAsync();
        }

        public async Task<Rastreio> ReadAsync(Guid id)
        {
            return await _rastreioRepository.ReadAsync(id);
        }

        public void Update(Rastreio entity)
        {
            _rastreioRepository.Update(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _rastreioRepository.DeleteAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _rastreioRepository.SaveChangesAsync();
        }
    }
}