using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Rastreios
{
    public class RastreioService : IRastreioService
    {
        private IRastreioRepository _rastreioRepository;

        public RastreioService(IRastreioRepository rastreioRepository)
        {
            _rastreioRepository = rastreioRepository;
        }

        public async Task AdicionarRastreioAsync(Rastreio rastreio)
        {
            await _rastreioRepository.CreateAsync(rastreio);
        }

        public async Task DeleteRastreioAsync(Guid id)
        {
            await _rastreioRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Rastreio>> GetAllRastreiosAsync()
        {
            return await _rastreioRepository.ReadAllAsync();
        }

        public async Task<Rastreio> GetRastreioAsync(Guid id)
        {
            return await _rastreioRepository.ReadAsync(id);
        }

        public void UpdateRastreio(Rastreio rastreio)
        {
            _rastreioRepository.Update(rastreio);
        }
    }
}
