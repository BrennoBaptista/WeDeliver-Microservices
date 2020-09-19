using System;
using System.Threading.Tasks;
using WeDeliver.Common.Application.CQRS.Messaging;
using WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application
{
    public class ApiApplicationService : IApiApplicationService
    {
        private IPostagemService _postagemService;
        private IMediatorHandler _bus;

        public ApiApplicationService(IPostagemService postagemService, IMediatorHandler bus)
        {
            _postagemService = postagemService;
            _bus = bus;
        }

        //Processa uma postagem e envia para enfileirar no serviceBus -- process-postagem-command-queue
        public async Task<Postagem> CriarPostagemAsync(Guid id_pacote, string destino, string recebedor)
        {
            var postagem = _postagemService.CriarPostagem(id_pacote, destino, recebedor);
            var command = new ProcessPostagemCommand(postagem);
            await _bus.EnqueueAsync(command, command.QueueName);
            return postagem;
        }

    }
}
