using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public class PacoteService : IPacoteService
    {
        private IPacoteRepository _pacoteRepository;

        public PacoteService(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public async Task CreateAsync(Pacote entity)
        {
            await _pacoteRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _pacoteRepository.DeleteAsync(id);
        }

        public IEnumerable<Pacote> ReadAll()
        {
            return _pacoteRepository.ReadAll();
        }

        public async Task<IEnumerable<Pacote>> ReadAllAsync()
        {
            return await _pacoteRepository.ReadAllAsync();
        }

        public async Task<Pacote> ReadAsync(Guid id)
        {
            return await _pacoteRepository.ReadAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _pacoteRepository.SaveChangesAsync();
        }

        public void Update(Pacote entity)
        {
            _pacoteRepository.Update(entity);
        }
    }
}
