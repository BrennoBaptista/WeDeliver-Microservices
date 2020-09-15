using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel
{
    public interface IClienteRepository : IRepository<Guid, Cliente>
    {
    }
}
