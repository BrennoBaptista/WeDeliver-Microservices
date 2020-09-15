using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public class PacoteAddedEvent
    {
        public Pacote Pacotes { get; set; }
    }
}
