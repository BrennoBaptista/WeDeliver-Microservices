using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public interface IPostagemService
    {
        Postagem CriarPostagem(Guid id_pacote, string destino, string recebedor);
        Task<bool> ProcessarPostagemAsync(Postagem postagem);
        Postagem GetPostagemPorPacote(Guid id_pacote);
    }
}
