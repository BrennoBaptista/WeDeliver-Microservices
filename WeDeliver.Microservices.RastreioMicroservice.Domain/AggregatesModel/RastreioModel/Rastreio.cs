using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    public class Rastreio
    {
        public Guid Id { get; set; }
        public Guid Id_Postagem { get; set; }
        public Guid Id_Pacote { get; set; }
        public Status Status { get; set; }
        public string Localizacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
