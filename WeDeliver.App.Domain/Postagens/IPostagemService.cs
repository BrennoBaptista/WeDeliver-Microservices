using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Postagens
{
    public interface IPostagemService
    {
        Task AdicionarPostagemAsync(Postagem postagem);
        Task<Postagem> GetPostagemAsync(Guid id);
        Task<IEnumerable<Postagem>> GetAllPostagensAsync();
        void UpdatePostagem(Postagem postagem);
        Task DeletePostagemAsync(Guid id);
    }
}
