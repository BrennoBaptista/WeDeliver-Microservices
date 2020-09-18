using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Infra.DataAccess;
using WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Repositories
{
    public class RastreioRepository : EntityFrameworkRepositoryBase<Guid, Rastreio>, IRastreioRepository
    {
        public RastreioRepository(DbContext context)
            : base(context)
        {
        }
    }
}
