using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    interface IRastreioService
    {
        Rastreio GetRastreioPorPacote(Guid id_pacote);
        Rastreio GetRastreioPorPostagem(Guid id_postagem);
    }
}
