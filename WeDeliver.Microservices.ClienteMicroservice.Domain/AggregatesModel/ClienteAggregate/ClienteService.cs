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

        public Cliente GetClientePorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
