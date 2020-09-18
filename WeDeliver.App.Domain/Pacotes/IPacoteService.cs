using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Pacotes
{
    public interface IPacoteService
    {
        Task AdicionarPacoteAsync(Pacote pacote);
        Task<Pacote> GetPacoteAsync(Guid id);
        Task<IEnumerable<Pacote>> GetAllPacotesAsync();
        void UpdatePacote(Pacote pacote);
        Task DeletePacoteAsync(Guid id);
    }
}