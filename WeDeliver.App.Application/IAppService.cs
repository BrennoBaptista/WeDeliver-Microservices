using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeDeliver.App.Domain;
using WeDeliver.App.Domain.Cliente;

namespace WeDeliver.App.Application
{
    public interface IAppService
    {
        //Clientes
        Task AdicionarClienteAsync(Cliente cliente);
        Task<Cliente> GetClienteAsync(Guid id);
        void UpdateCliente(Cliente cliente);
        Task DeleteClienteAsync(Guid id);
        Task<IEnumerable<Cliente>> GetAllClientesAsync();

        //Postagens
        Task AdicionarPostagemAsync(Postagem postViewModel);
        Task<IEnumerable<Postagem>> GetAllPostagensAsync();










    }
}
