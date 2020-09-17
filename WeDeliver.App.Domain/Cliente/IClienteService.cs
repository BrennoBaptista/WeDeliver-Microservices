using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Cliente
{
    public interface IClienteService
    {
        Task AdicionarClienteAsync(Cliente cliente);
        Task<Cliente> GetClienteAsync(Guid id);
        void UpdateCliente(Cliente cliente);
        Task DeleteClienteAsync(Guid id);
        Task<IEnumerable<Cliente>> GetAllClientesAsync();
    }
}
