using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Infra.DataAccess;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Repositories
{
    public class PostagemRepository : EntityFrameworkRepositoryBase<Guid, Postagem>, IPostagemRepository
    {
        public PostagemRepository(DbContext context)
            : base(context)
        {

        }
    }
}
