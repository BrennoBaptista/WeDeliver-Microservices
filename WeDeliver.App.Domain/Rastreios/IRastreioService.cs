using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeDeliver.App.Domain.Rastreios
{
    public interface IRastreioService
    {
        Task AdicionarRastreioAsync(Rastreio rastreio);
        Task<Rastreio> GetRastreioAsync(Guid id);
        Task<IEnumerable<Rastreio>> GetAllRastreiosAsync();
        void UpdateRastreio(Rastreio rastreio);
        Task DeleteRastreioAsync(Guid id);
    }
}
