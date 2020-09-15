using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Common.Domain.Entities
{
    public class Endereco : EntidadeBase<Guid>
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Lote { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }

        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, string lote, string complemento, string referencia)
        {
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Lote = lote;
            Complemento = complemento;
            Referencia = referencia;
        }

        public Endereco() { }
    }
}
