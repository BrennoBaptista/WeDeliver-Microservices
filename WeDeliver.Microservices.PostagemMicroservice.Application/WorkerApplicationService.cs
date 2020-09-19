using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Application.CQRS.Messaging;
using WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands;
using WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Events;

namespace WeDeliver.Microservices.PostagemMicroservice.Application
{
    public class WorkerApplicationService : IWorkerApplicationService
    {
        private IPostagemCommandHandler _postagemCommandHandler;
        private IMediatorHandler _bus;

        public WorkerApplicationService(IPostagemCommandHandler postagemCommandHandler, IMediatorHandler bus)
        {
            _postagemCommandHandler = postagemCommandHandler;
            _bus = bus;
        }

        //Gera a postagem e envia para a fila de eventos -- postagem-processed-event-queue
        public async Task ProcessPostagemAsync(ProcessPostagemCommand command)
        {
            var commandHandlerSuccess = await _postagemCommandHandler.HandleAsync(command);
            var postagemProcessedEvent = new PostagemProcessedEvent(command.Postagem);
            postagemProcessedEvent.Success = true;

            if (!commandHandlerSuccess)
                postagemProcessedEvent.Success = false;

            await _bus.EnqueueAsync(postagemProcessedEvent, postagemProcessedEvent.QueueName);
        }
    }
}
