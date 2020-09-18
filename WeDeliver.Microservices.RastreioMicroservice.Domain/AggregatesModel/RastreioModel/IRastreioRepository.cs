using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    public interface IRastreioRepository : IRepository<Guid, Rastreio>
    {
    }
}
