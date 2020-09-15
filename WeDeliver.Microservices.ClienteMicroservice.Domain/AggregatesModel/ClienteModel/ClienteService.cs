using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

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
        }
    }
}
