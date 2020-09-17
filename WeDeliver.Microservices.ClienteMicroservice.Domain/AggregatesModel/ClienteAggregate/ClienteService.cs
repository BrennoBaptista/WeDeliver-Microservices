using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

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





        /*
        public Cliente AdicionarCliente(string nome, string telefone, string cpf, string email, string endereco)
        {
            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Telefone = telefone,
                Cpf = cpf,
                Email = email,
                Endereco = endereco,
            };
            return cliente;
        }

        public async Task<bool> ProcessarClienteAsync(Cliente cliente)
        {
            await _clienteRepository.CreateAsync(cliente);
            return await _clienteRepository.SaveChangesAsync() > 0;
        }*/
    }
}
