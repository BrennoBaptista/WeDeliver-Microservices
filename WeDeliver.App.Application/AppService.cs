using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain;
using WeDeliver.App.Domain.Cliente;
using WeDeliver.App.Infra.DataAccess.Repositories;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.App.Application
{
    public class AppService : IAppService
    {
        private ISerializerService _serializerService;

        public AppService(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        //Clientes
        public async Task AdicionarClienteAsync(Cliente clienteViewModel)
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            await clienteService.AdicionarClienteAsync(clienteViewModel);
        }
        public async Task<Cliente> GetClienteAsync(Guid id)
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            return await clienteService.GetClienteAsync(id);
        }
        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            return await clienteService.GetAllClientesAsync();
        }
        public void UpdateCliente(Cliente cliente)
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            clienteService.UpdateCliente(cliente);
        }
        public async Task DeleteClienteAsync(Guid id)
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            await clienteService.DeleteClienteAsync(id);
        }

        //-------------------------------------------------------------------

        //Postagens
        public async Task AdicionarPostagemAsync(Postagem postagemViewModel)
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            await postagemService.AdicionarPostagemAsync(postagemViewModel);
        }

        public async Task<IEnumerable<Postagem>> GetAllPostagensAsync()
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            return await postagemService.GetAllPostagensAsync();
        }
    }
}
