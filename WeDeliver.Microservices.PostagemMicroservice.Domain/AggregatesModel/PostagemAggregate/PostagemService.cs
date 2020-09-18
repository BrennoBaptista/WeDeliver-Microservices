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

        public Postagem GetPostagemPorPacote(Guid pacoteId)
        {
            return _postagemRepository.GetPostagemPorPacote(pacoteId);
        }
    }
}
