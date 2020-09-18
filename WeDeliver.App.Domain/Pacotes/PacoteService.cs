using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Pacotes
{
    public class PacoteService : IPacoteService
    {
        private IPacoteRepository _pacoteRepository;

        public PacoteService(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public async Task AdicionarPacoteAsync(Pacote pacote)
        {
            await _pacoteRepository.CreateAsync(pacote);
        }

        public async Task DeletePacoteAsync(Guid id)
        {
            await _pacoteRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Pacote>> GetAllPacotesAsync()
        {
            return await _pacoteRepository.ReadAllAsync();
        }

        public async Task<Pacote> GetPacoteAsync(Guid id)
        {
            return await _pacoteRepository.ReadAsync(id);
        }

        public void UpdatePacote(Pacote pacote)
        {
            _pacoteRepository.Update(pacote);
        }
    }
}