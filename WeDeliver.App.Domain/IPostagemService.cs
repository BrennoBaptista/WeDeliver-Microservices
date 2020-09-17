using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain
{
    public interface IPostagemService
    {
        Task AdicionarPostagemAsync(Postagem postagem);
        Task<IEnumerable<Postagem>> GetAllPostagensAsync();
    }
}
