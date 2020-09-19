using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;

namespace WeDeliver.Microservices.PostagemMicroservice.Application
{
    public interface IApiApplicationService
    {
        Task<Postagem> CriarPostagemAsync(Guid id_pacote, string destino, string recebedor);
    }
}
