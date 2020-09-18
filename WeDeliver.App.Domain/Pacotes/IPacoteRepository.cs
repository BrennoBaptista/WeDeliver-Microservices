using System;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.App.Domain.Pacotes
{
    public interface IPacoteRepository : IRepository<Guid, Pacote>
    {
    }
}