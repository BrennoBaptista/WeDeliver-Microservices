using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Clientes
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task AdicionarClienteAsync(Cliente cliente)
        {
            await _clienteRepository.CreateAsync(cliente);
        }

        public async Task DeleteClienteAsync(Guid id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _clienteRepository.ReadAllAsync();
        }

        public async Task<Cliente> GetClienteAsync(Guid id)
        {
            return await _clienteRepository.ReadAsync(id);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }
    }
}
