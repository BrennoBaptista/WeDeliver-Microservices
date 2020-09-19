using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands;

namespace WeDeliver.Microservices.PostagemMicroservice.Application
{
    public interface IWorkerApplicationService
    {
        Task ProcessPostagemAsync(ProcessPostagemCommand command);
    }
}
