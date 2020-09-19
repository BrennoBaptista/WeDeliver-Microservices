using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands
{

    //Use Case: Process Postagem
    public class ProcessPostagemCommand : PostagemCommand
    {
        public const string CommandQueueName = "process-postagem-command-queue";
        public override string QueueName => CommandQueueName;

        public ProcessPostagemCommand(Postagem postagem) :base(postagem)
        {
        }

        public ProcessPostagemCommand() :base()
        {
        }
    }
}
