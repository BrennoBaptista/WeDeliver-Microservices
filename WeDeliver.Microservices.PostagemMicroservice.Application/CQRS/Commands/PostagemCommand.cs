using System;
using System.Collections.Generic;
using System.Text;
using WeDeliver.Common.Application.CQRS.Commands;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands
{
    public abstract class PostagemCommand : Command
    {
        public Postagem Postagem { get; set; }

        protected PostagemCommand(Postagem postagem) :base()
        {
            Postagem = postagem;
        }

        protected PostagemCommand() :base()
        {
        }
    }
}
