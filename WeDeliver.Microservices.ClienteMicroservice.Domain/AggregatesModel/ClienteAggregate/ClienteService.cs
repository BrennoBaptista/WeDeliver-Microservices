using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteAggregate
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task CreateAsync(Cliente entity)
        {
            await _clienteRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public IEnumerable<Cliente> ReadAll()
        {
            return _clienteRepository.ReadAll();
        }

        public async Task<IEnumerable<Cliente>> ReadAllAsync()
        {
            return await _clienteRepository.ReadAllAsync();
        }

        public async Task<Cliente> ReadAsync(Guid id)
        {
            return await _clienteRepository.ReadAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _clienteRepository.SaveChangesAsync();
        }

        public void Update(Cliente entity)
        {
            _clienteRepository.Update(entity);
        }
    }
}
