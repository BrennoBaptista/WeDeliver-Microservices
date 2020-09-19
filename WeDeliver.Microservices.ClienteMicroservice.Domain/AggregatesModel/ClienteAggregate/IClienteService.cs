using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteAggregate
{
    public interface IClienteService
    {
        Cliente GetClientePorNome(string nome);
    }
}
