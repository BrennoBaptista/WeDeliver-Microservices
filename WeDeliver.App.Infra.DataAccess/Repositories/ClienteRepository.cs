using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain.Clientes;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.App.Infra.DataAccess.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private ISerializerService _serializerService;
        public ClienteRepository(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        //Cria um cliente através da api publicada no azure
        public async Task CreateAsync(Cliente entity)
        {
            var httpClient = new HttpClient();
            var serializedCliente = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes", httpContent);
        }

        //Requisita um cliente através da api publicada no azure
        public async Task<Cliente> ReadAsync(Guid id)
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes/" + $"{id}");

            string serializedCliente = await result.Content.ReadAsStringAsync();
            var cliente = _serializerService.Deserialize<Cliente>(serializedCliente);

            return cliente;
        }

        //Requisita todas os clientes através da api publicada no azure
        public IEnumerable<Cliente> ReadAll()
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes").Result;

            if (!result.IsSuccessStatusCode)
                return new List<Cliente>();

            var serializedClientes = result.Content.ReadAsStringAsync().Result;
            var clientes = _serializerService.Deserialize<IEnumerable<Cliente>>(serializedClientes);

            return clientes;
        }

        //Requisita todas as clientes através da api publicada no azure
        public async Task<IEnumerable<Cliente>> ReadAllAsync()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes");

            if (!result.IsSuccessStatusCode)
                return new List<Cliente>();

            var serializedClientes = await result.Content.ReadAsStringAsync();
            var clientes = _serializerService.Deserialize<IEnumerable<Cliente>>(serializedClientes);

            return clientes;
        }

        //Atualiza um cliente através da api publicada no azure
        public void Update(Cliente entity)
        {
            var httpClient = new HttpClient();
            string serializedCliente = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
            httpClient.PutAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes/" + $"{entity.Id}", httpContent);
        }

        //Deleta um cliente através da api publicada no azure
        public async Task DeleteAsync(Guid id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("http://wedeliver-cliente-microservice-api-brenno.azurewebsites.net/api/clientes/" + $"{id}");
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
