using System;
using System.Collections.Generic;
using System.Text;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public class PostagemAddedEvent
    {
        public Postagem Postagem { get; set; }
    }
}
