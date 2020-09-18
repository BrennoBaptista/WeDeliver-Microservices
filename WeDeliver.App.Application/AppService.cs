using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain;
using WeDeliver.App.Domain.Clientes;
using WeDeliver.App.Domain.Pacotes;
using WeDeliver.App.Domain.Postagens;
using WeDeliver.App.Domain.Rastreios;
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

        //-------------------------------------------------------------------
        //Clientes
        public async Task AdicionarClienteAsync(Cliente cliente)
        {
            var clienteRepository = new ClienteRepository(_serializerService);
            var clienteService = new ClienteService(clienteRepository);
            await clienteService.AdicionarClienteAsync(cliente);
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
        //Pacotes
        public async Task AdicionarPacoteAsync(Pacote pacote)
        {
            var pacoteRepository = new PacoteRepository(_serializerService);
            var pacoteService = new PacoteService(pacoteRepository);
            await pacoteService.AdicionarPacoteAsync(pacote);
        }
        public async Task<Pacote> GetPacoteAsync(Guid id)
        {
            var pacoteRepository = new PacoteRepository(_serializerService);
            var pacoteService = new PacoteService(pacoteRepository);
            return await pacoteService.GetPacoteAsync(id);
        }
        public void UpdatePacote(Pacote pacote)
        {
            var pacoteRepository = new PacoteRepository(_serializerService);
            var pacoteService = new PacoteService(pacoteRepository);
            pacoteService.UpdatePacote(pacote);
        }
        public async Task DeletePacoteAsync(Guid id)
        {
            var pacoteRepository = new PacoteRepository(_serializerService);
            var pacoteService = new PacoteService(pacoteRepository);
            await pacoteService.DeletePacoteAsync(id);
        }
        public async Task<IEnumerable<Pacote>> GetAllPacotesAsync()
        {
            var pacoteRepository = new PacoteRepository(_serializerService);
            var pacoteService = new PacoteService(pacoteRepository);
            return await pacoteService.GetAllPacotesAsync();
        }

        //-------------------------------------------------------------------
        //Postagens
        public async Task AdicionarPostagemAsync(Postagem postagem)
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            await postagemService.AdicionarPostagemAsync(postagem);
        }
        public async Task<Postagem> GetPostagemAsync(Guid id)
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            return await postagemService.GetPostagemAsync(id);
        }
        public void UpdatePostagem(Postagem postagem)
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            postagemService.UpdatePostagem(postagem);
        }
        public async Task DeletePostagemAsync(Guid id)
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            await postagemService.DeletePostagemAsync(id);
        }
        public async Task<IEnumerable<Postagem>> GetAllPostagensAsync()
        {
            var postagemRepository = new PostagemRepository(_serializerService);
            var postagemService = new PostagemService(postagemRepository);
            return await postagemService.GetAllPostagensAsync();
        }

        //-------------------------------------------------------------------
        //Rastreios
        public async Task AdicionarRastreioAsync(Rastreio rastreio)
        {
            var rastreioRepository = new RastreioRepository(_serializerService);
            var rastreioService = new RastreioService(rastreioRepository);
            await rastreioService.AdicionarRastreioAsync(rastreio);
        }
        public async Task<Rastreio> GetRastreioAsync(Guid id)
        {
            var rastreioRepository = new RastreioRepository(_serializerService);
            var rastreioService = new RastreioService(rastreioRepository);
            return await rastreioService.GetRastreioAsync(id);
        }
        public void UpdateRastreio(Rastreio rastreio)
        {
            var rastreioRepository = new RastreioRepository(_serializerService);
            var rastreioService = new RastreioService(rastreioRepository);
            rastreioService.UpdateRastreio(rastreio);
        }
        public async Task DeleteRastreioAsync(Guid id)
        {
            var rastreioRepository = new RastreioRepository(_serializerService);
            var rastreioService = new RastreioService(rastreioRepository);
            await rastreioService.DeleteRastreioAsync(id);
        }
        public async Task<IEnumerable<Rastreio>> GetAllRastreiosAsync()
        {
            var rastreioRepository = new RastreioRepository(_serializerService);
            var rastreioService = new RastreioService(rastreioRepository);
            return await rastreioService.GetAllRastreiosAsync();
        }
    }
}