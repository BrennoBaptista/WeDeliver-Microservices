using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public interface IPostagemRepository : IRepository<Guid, Postagem>
    {
    }
}
