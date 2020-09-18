using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain.Rastreios;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.App.Infra.DataAccess.Repositories
{
    public class RastreioRepository : IRastreioRepository
    {
        private ISerializerService _serializerService;

        public RastreioRepository(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        public async Task CreateAsync(Rastreio entity)
        {
            var httpClient = new HttpClient();
            var serializedRastreio = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedRastreio, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios", httpContent);
        }

        public IEnumerable<Rastreio> ReadAll()
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios").Result;

            if (!result.IsSuccessStatusCode)
                return new List<Rastreio>();

            var serializedRastreios = result.Content.ReadAsStringAsync().Result;
            var rastreios = _serializerService.Deserialize<IEnumerable<Rastreio>>(serializedRastreios);

            return rastreios;
        }

        public async Task<IEnumerable<Rastreio>> ReadAllAsync()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios");

            if (!result.IsSuccessStatusCode)
                return new List<Rastreio>();

            var serializedRastreios = await result.Content.ReadAsStringAsync();
            var rastreios = _serializerService.Deserialize<IEnumerable<Rastreio>>(serializedRastreios);

            return rastreios;
        }

        public async Task<Rastreio> ReadAsync(Guid id)
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios/" + $"{id}");

            string serializedRastreio = await result.Content.ReadAsStringAsync();
            var rastreio = _serializerService.Deserialize<Rastreio>(serializedRastreio);

            return rastreio;
        }

        public void Update(Rastreio entity)
        {
            var httpClient = new HttpClient();
            string serializedCliente = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
            httpClient.PutAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios/" + $"{entity.Id}", httpContent);
        }

        public async Task DeleteAsync(Guid id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("https://wedeliver-rastreio-microservice-api-brenno.azurewebsites.net/api/rastreios/" + $"{id}");
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
