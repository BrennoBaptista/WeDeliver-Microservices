using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public interface IPostagemService : IBaseService<Guid, Postagem>
    {
        Postagem AdicionarPostagem(Guid pacoteId, string destino, string recebedor);
        Task<bool> ProcessarPostagemAsync(Postagem postagem);
        Postagem GetPostagemPorPacote(Guid pacoteId);
    }
}
