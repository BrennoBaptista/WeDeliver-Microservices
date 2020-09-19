using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Events
{
    public class PostagemProcessedEvent : PostagemEvent
    {
        public const string EventQueueName = "postagem-processed-event-queue";
        public override string QueueName => EventQueueName;
        public bool Success { get; set; }

        public PostagemProcessedEvent(Postagem postagem) : base()
        {
            Postagem = postagem;
        }

        public PostagemProcessedEvent() :base()
        {
        }
    }
}
