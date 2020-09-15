using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public class PostagemService : IPostagemService
    {
        private IPostagemRepository _postagemRepository;

        public PostagemService(IPostagemRepository postagemRepository)
        {
            _postagemRepository = postagemRepository;
        }

        public Postagem AdicionarPostagem(Guid pacoteId, string destino, string recebedor)
        {
            var postagem = new Postagem
            {
                Id = Guid.NewGuid(),
                Id_Pacote = pacoteId,
                DataEnvio = DateTime.Now,
                Destino = destino,
                Recebedor = recebedor,
            };
            return postagem;
        }

        public async Task<bool> ProcessarPostagemAsync(Postagem postagem)
        {
            await _postagemRepository.CreateAsync(postagem);
            return await _postagemRepository.SaveChangesAsync() > 0;
        }
    }
}
