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

        public Pacote GetPacotePorCliente(Guid id_cliente)
        {
            throw new NotImplementedException();
        }
    }
}
