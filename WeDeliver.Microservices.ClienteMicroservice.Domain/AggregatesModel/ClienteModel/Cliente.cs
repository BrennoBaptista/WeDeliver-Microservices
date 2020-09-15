using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.ClienteMicroservice.Domain.AggregatesModel.ClienteModel
{
    public class Cliente : EntidadeBase<Guid>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string telefone, string cpf, string email, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }

        public Cliente() { }
    }
}
