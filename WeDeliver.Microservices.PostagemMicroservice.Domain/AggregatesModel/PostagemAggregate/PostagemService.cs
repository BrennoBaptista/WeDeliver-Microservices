using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public class PostagemService : IPostagemService
    {
        private IPostagemRepository _postagemRepository;

        public PostagemService(IPostagemRepository postagemRepository)
        {
            _postagemRepository = postagemRepository;
        }

        public Postagem CriarPostagem(Guid id_pacote, string destino, string recebedor)
        {
            var postagem = new Postagem
            {
                Id = Guid.NewGuid(),
                Id_Pacote = id_pacote,
                Destino = destino,
                Recebedor = recebedor,
                DataEnvio = DateTime.Now
            };
            return postagem;
        }

        public Postagem GetPostagemPorPacote(Guid id_pacote)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ProcessarPostagemAsync(Postagem postagem)
        {
            if(postagem.Destino == null || postagem.Recebedor == null)
            {
                throw new Exception("Informe o destino e/ou recebedor.");
            }

            await _postagemRepository.CreateAsync(postagem);
            return await _postagemRepository.SaveChangesAsync() > 0;
        }
    }
}
