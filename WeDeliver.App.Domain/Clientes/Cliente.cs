using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.App.Domain.Clientes
{
    public class Cliente : EntidadeBase<Guid>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
