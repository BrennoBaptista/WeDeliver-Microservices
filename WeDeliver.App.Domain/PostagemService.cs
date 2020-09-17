using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain
{
    public class PostagemService : IPostagemService
    {
        private IPostagemRepository _postagemRepository;
        public PostagemService(IPostagemRepository postagemRepository)
        {
            _postagemRepository = postagemRepository;
        }

        public async Task AdicionarPostagemAsync(Postagem postagem)
        {
            await _postagemRepository.CreateAsync(postagem);

        }

        public async Task<IEnumerable<Postagem>> GetAllPostagensAsync()
        {
            return await _postagemRepository.ReadAllAsync();
        }
    }
}
