using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public interface IPostagemService
    {
        Postagem AdicionarPostagem(Guid pacoteId, string destino, string recebedor);
        Task<bool> ProcessarPostagemAsync(Postagem postagem);
    }
}
