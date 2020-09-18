using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.App.Domain.Postagens
{
    public interface IPostagemRepository : IRepository<Guid, Postagem>
    {
    }
}
