using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeDeliver.App.Domain;
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

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
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

        public Task<Postagem> ReadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Postagem entity)
        {
            throw new NotImplementedException();
        }
    }
}
