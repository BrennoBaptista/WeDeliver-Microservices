using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Infra.DataAccess;
using WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate;

namespace WeDeliver.Microservices.PacoteMicroservice.Infra.DataAccess.Repositories
{
    public class PacoteRepository : EntityFrameworkRepositoryBase<Guid, Pacote>, IPacoteRepository
    {
        public PacoteRepository(DbContext context)
            : base(context)
        {
        }
    }
}
