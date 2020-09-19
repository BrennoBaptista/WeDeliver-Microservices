using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public interface IPacoteService
    {
        Pacote GetPacotePorCliente(Guid id_cliente);
    }
}
