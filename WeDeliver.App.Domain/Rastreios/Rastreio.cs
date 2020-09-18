using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.App.Domain.Rastreios
{
    public class Rastreio : EntidadeBase<Guid>
    {
        public Guid Id_Postagem { get; set; }
        public Guid Id_Pacote { get; set; }
        public StatusEnvio StatusEnvio { get; set; }
        public string Localizacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
