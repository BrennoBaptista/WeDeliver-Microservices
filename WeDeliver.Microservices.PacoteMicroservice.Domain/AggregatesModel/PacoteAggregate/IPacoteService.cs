using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public interface IPacoteService
    {
        Pacote AdicionarPacote(Guid clienteId, double peso, double altura, double largura, double profundidade);
        Task<bool> ProcessarPacoteAsync(Pacote pacote);
    }
}
