using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeDeliver.App.Domain.Postagens;
using WeDeliver.App.Domain.Clientes;
using WeDeliver.App.Domain.Pacotes;
using WeDeliver.App.Domain.Rastreios;

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

        //Pacotes
        Task AdicionarPacoteAsync(Pacote pacote);
        Task<Pacote> GetPacoteAsync(Guid id);
        void UpdatePacote(Pacote pacote);
        Task DeletePacoteAsync(Guid id);
        Task<IEnumerable<Pacote>> GetAllPacotesAsync();

        //Postagens
        Task AdicionarPostagemAsync(Postagem postagem);
        Task<Postagem> GetPostagemAsync(Guid id);
        void UpdatePostagem(Postagem postagem);
        Task DeletePostagemAsync(Guid id);
        Task<IEnumerable<Postagem>> GetAllPostagensAsync();

        //Rastreios
        Task AdicionarRastreioAsync(Rastreio rastreio);
        Task<Rastreio> GetRastreioAsync(Guid id);
        void UpdateRastreio(Rastreio rastreio);
        Task DeleteRastreioAsync(Guid id);
        Task<IEnumerable<Rastreio>> GetAllRastreiosAsync();
    }
}
