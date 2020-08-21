using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace GitChallenge.Infrastructure.Clients
{
    public abstract class VirtualClient : IClient
    {
        public readonly IFlurlClient _client;
        public VirtualResources RESOURCES;

        protected VirtualClient()
        {
                
        }

        public Task<List<T>> GetListAsync<T>(object query = null, string path = null, Dictionary<string, string> header = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(object entityId, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByQueryAsync<T>(object query = null, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync<T>(T entity, string path = null, object query = null)
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsyncReceiveString<T>(T entity, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostByQueryAsync<T>(T entity, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> PatchAsync<T>(object entityId, T entity, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutAsync<T>(object entityId, T entity, string path = null, object query = null)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object entityId, string path = null)
        {
            throw new NotImplementedException();
        }

        public Task HandleErrorAsync(HttpCall call)
        {
            throw new NotImplementedException();
        }

        public Task HandleBeforeCallAsync(HttpCall call)
        {
            throw new NotImplementedException();
        }

        public Task HandleAfterCallAsync(HttpCall call)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsyncService<T>(object body, string path = null)
        {
            throw new NotImplementedException();
        }
    }
}
