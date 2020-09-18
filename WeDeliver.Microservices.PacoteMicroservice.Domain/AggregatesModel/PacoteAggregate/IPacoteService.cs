using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.Microservices.PacoteMicroservice.Domain.AggregatesModel.PacoteAggregate
{
    public interface IPacoteService
    {
        Task CreateAsync(Pacote entity);
        Task DeleteAsync(Guid id);
        void Update(Pacote entity);
        Task<Pacote> ReadAsync(Guid id);
        IEnumerable<Pacote> ReadAll();
        Task<IEnumerable<Pacote>> ReadAllAsync();
        Task<int> SaveChangesAsync();
    }
}
