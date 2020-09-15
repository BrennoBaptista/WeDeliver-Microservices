using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel
{
    public interface IClienteService
    {
        Cliente AdicionarCliente(string nome, string telefone, string cpf, string email, string endereco);
        Task<bool> ProcessarClienteAsync(Cliente cliente);
    }
}
