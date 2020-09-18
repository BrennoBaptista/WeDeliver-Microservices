using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.App.Domain.Rastreios
{
    public interface IRastreioRepository : IRepository<Guid, Rastreio>
    {
    }
}
