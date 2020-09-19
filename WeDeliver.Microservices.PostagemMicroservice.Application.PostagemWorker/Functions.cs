using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Services;
using WeDeliver.Common.Infra.Helper.Serializers;
using WeDeliver.Common.Infra.Messaging.Services;
using WeDeliver.Microservices.PostagemMicroservice.Application;
using WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Contexts;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Repositories;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.PostagemWorker
{
    public class Functions
    {
        private static IWorkerApplicationService _workerApplicationService = new WorkerApplicationService(new PostagemCommandHandler(new PostagemService(new PostagemRepository(new PostagemContext()))), new AzureServiceBusQueue());     //(new ProductQueryService(new ProductMicroserviceQueryRepository(new SerializerService())), new OrderRepository(new OrderContext()))), new AzureServiceBusQueue());
        private static ISerializerService _serializerService = new SerializerService();

        public static async Task ProcessPostagemCommandFunction([ServiceBusTrigger(ProcessPostagemCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = _serializerService.Deserialize<ProcessPostagemCommand>(message);
            await _workerApplicationService.ProcessPostagemAsync(command);
        }
    }
}
