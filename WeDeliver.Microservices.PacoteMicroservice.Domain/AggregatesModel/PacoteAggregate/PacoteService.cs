using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public class PacoteService : IPacoteService
    {
        private IPacoteRepository _pacoteRepository;
        public PacoteService(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public Pacote AdicionarPacote(Guid clienteId, double peso, double altura, double largura, double profundidade)
        {
            var pacote = new Pacote
            {
                Id = Guid.NewGuid(),
                Id_Cliente = clienteId,
                Peso = peso,
                Altura = altura,
                Largura = largura,
                Profundidade = profundidade,
            };
            return pacote;
        }

        public async Task<bool> ProcessarPacoteAsync(Pacote pacote)
        {
            await _pacoteRepository.CreateAsync(pacote);
            return await _pacoteRepository.SaveChangesAsync() > 0;
        }
    }
}
