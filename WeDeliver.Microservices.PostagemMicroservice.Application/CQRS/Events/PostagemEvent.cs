using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Application.CQRS.Events;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Events
{
    public abstract class PostagemEvent : Event
    {
        public Postagem Postagem { get; set; }

        protected PostagemEvent() :base()
        {
        }
    }
}
