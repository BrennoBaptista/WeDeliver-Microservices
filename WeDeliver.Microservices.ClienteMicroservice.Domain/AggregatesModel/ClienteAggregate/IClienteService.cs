using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteAggregate
{
    public interface IClienteService
    {
        Task CreateAsync(Cliente entity);
        Task DeleteAsync(Guid id);
        void Update(Cliente entity);
        Task<Cliente> ReadAsync(Guid id);
        IEnumerable<Cliente> ReadAll();
        Task<IEnumerable<Cliente>> ReadAllAsync();
        Task<int> SaveChangesAsync();

        /*Cliente AdicionarCliente(string nome, string telefone, string cpf, string email, string endereco);
        Task<bool> ProcessarClienteAsync(Cliente cliente);*/
    }
}
