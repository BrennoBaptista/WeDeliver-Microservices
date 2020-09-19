using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.CQRS.Commands
{
    public interface IPostagemCommandHandler
    {
        Task<bool> HandleAsync(ProcessPostagemCommand command);
    }
}
