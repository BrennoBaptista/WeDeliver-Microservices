using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Clientes
{
    public interface IClienteService
    {
        Task AdicionarClienteAsync(Cliente cliente);
        Task<Cliente> GetClienteAsync(Guid id);
        Task<IEnumerable<Cliente>> GetAllClientesAsync();
        void UpdateCliente(Cliente cliente);
        Task DeleteClienteAsync(Guid id);
    }
}
