using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Services;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands
{
    public class PostagemCommandHandler : IPostagemCommandHandler
    {
        private IPostagemService _postagemService;

        public PostagemCommandHandler(IPostagemService postagemService)
        {
            _postagemService = postagemService;
        }


        public async Task<bool> HandleAsync(ProcessPostagemCommand command)
        {
           return await _postagemService.ProcessarPostagemAsync(command.Postagem);
        }
    }
}
