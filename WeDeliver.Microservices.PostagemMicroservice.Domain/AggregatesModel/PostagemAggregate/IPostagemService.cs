using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.Common.Domain.Entities;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate
{
    public interface IPostagemService
    {
        Postagem GetPostagemPorPacote(Guid pacoteId);
    }
}
