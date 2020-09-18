using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain.Postagens;
using WeDeliver.Common.Domain.Services;

namespace WeDeliver.App.Infra.DataAccess.Repositories
{
    public class PostagemRepository : IPostagemRepository
    {
        private ISerializerService _serializerService;

        public PostagemRepository(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        public async Task CreateAsync(Postagem entity)
        {
            var httpClient = new HttpClient();
            var serializedPost = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedPost, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens", httpContent);
        }

        public async Task<Postagem> ReadAsync(Guid id)
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens/" + $"{id}");

            string serializedPostagem = await result.Content.ReadAsStringAsync();
            var postagem = _serializerService.Deserialize<Postagem>(serializedPostagem);

            return postagem;
        }
        
        public IEnumerable<Postagem> ReadAll()
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens").Result;

            if (!result.IsSuccessStatusCode)
                return new List<Postagem>();

            var serializedPostagens = result.Content.ReadAsStringAsync().Result;
            var postagens = _serializerService.Deserialize<IEnumerable<Postagem>>(serializedPostagens);

            return postagens;
        }

        public async Task<IEnumerable<Postagem>> ReadAllAsync()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens");

            if (!result.IsSuccessStatusCode)
                return new List<Postagem>();

            var serializedPostagens = await result.Content.ReadAsStringAsync();
            var postagens = _serializerService.Deserialize<IEnumerable<Postagem>>(serializedPostagens);

            return postagens;
        }

        public void Update(Postagem entity)
        {
            var httpClient = new HttpClient();
            string serializedPostagem = _serializerService.Serialize(entity);
            var httpContent = new StringContent(serializedPostagem, Encoding.UTF8, "application/json");
            httpClient.PutAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens/" + $"{entity.Id}", httpContent);
        }

        public async Task DeleteAsync(Guid id)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync("http://wedeliver-postagem-microservice-api-brenno.azurewebsites.net/api/postagens/" + $"{id}");
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}