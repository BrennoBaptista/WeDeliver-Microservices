using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Infra.DataAccess;
using WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteAggregate;
using WeDeliver.Microservices.ClienteMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.ClienteMicroservice.Infra.DataAccess.Repositories
{
    public class ClienteRepository : EntityFrameworkRepositoryBase<Guid, Cliente>, IClienteRepository
    {
        //private readonly ClienteContext _context;
        public ClienteRepository(DbContext context)
            : base(context)
        {
            //_context = (ClienteContext)context;
        }
    }
}