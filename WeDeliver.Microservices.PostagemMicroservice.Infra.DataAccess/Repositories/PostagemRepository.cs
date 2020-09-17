using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Infra.DataAccess;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Repositories
{
    public class PostagemRepository : EntityFrameworkRepositoryBase<Guid, Postagem>, IPostagemRepository
    {
        private readonly DbContext _context;
        public PostagemRepository(DbContext context)
            : base(context)
        {
            _context = context;
        }

        public Postagem GetPostagemPorPacote(Guid pacoteId)
        {
            return _context.Set<Postagem>().Find(pacoteId);
        }
    }
}
