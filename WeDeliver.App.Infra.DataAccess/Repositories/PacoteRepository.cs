using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain.Pacotes;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.App.Infra.DataAccess.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        private ISerializerService _serializerService;

        public PacoteRepository(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        //Cria uma pacote através da api publicada no azure
        public async Task CreateAsync(Pacote entity)
        {
            var httpClient = new HttpClient();
            var serializedPacote = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedPacote, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes", httpContent);
        }

        //Requisita um pacote através da api publicada no azure
        public async Task<Pacote> ReadAsync(Guid id)
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes/" + $"{id}");

            string serializedPacote = await result.Content.ReadAsStringAsync();
            var pacote = _serializerService.Deserialize<Pacote>(serializedPacote);

            return pacote;
        }

        //Requisita todas os pacotes através da api publicada no azure
        public IEnumerable<Pacote> ReadAll()
        {

            var httpClient = new HttpClient();
            var result = httpClient.GetAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes").Result;

            if (!result.IsSuccessStatusCode)
                return new List<Pacote>();

            var serializedPacotes = result.Content.ReadAsStringAsync().Result;
            var pacotes = _serializerService.Deserialize<IEnumerable<Pacote>>(serializedPacotes);

            return pacotes;
        }

        //Requisita todas as pacotes através da api publicada no azure
        public async Task<IEnumerable<Pacote>> ReadAllAsync()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes/");

            if (!result.IsSuccessStatusCode)
                return new List<Pacote>();

            var serializedPacotes = await result.Content.ReadAsStringAsync();
            var pacotes = _serializerService.Deserialize<IEnumerable<Pacote>>(serializedPacotes);

            return pacotes;
        }

        //Atualiza um pacote através da api publicada no azure
        public void Update(Pacote entity)
        {
            var httpClient = new HttpClient();
            string serializedCliente = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedCliente, Encoding.UTF8, "application/json");
            httpClient.PutAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes/" + $"{entity.Id}", httpContent);
        }

        //Deleta um pacote através da api publicada no azure
        public async Task DeleteAsync(Guid id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("https://wedeliver-pacote-microservice-api-brenno.azurewebsites.net/api/pacotes/" + $"{id}");
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
