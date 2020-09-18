using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.RastreioMicroservice.Domain.AggregatesModel.RastreioModel
{
    interface IRastreioService
    {
        Task CreateAsync(Rastreio entity);
        void Update(Rastreio entity);
        Task<Rastreio> ReadAsync(Guid id);
        IEnumerable<Rastreio> ReadAll();
        Task<IEnumerable<Rastreio>> ReadAllAsync();
        Task DeleteAsync(Guid id);
        Task<int> SaveChangesAsync();
    }
}
