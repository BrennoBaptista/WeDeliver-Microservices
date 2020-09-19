using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    public class RastreioService : IRastreioService
    {
        private IRastreioRepository _rastreioRepository;

        public RastreioService(IRastreioRepository rastreioRepository)
        {
            _rastreioRepository = rastreioRepository;
        }

        public Rastreio GetRastreioPorPacote(Guid id_pacote)
        {
            throw new NotImplementedException();
        }

        public Rastreio GetRastreioPorPostagem(Guid id_postagem)
        {
            throw new NotImplementedException();
        }
    }
}