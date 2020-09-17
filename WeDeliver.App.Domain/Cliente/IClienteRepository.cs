using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Repositories;

namespace WeDeliver.App.Domain.Cliente
{
    public interface IClienteRepository : IRepository<Guid, Cliente>
    {
    }
}
