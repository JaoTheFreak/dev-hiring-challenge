using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace GitChallenge.Infrastructure.Clients
{
    public interface IClient
    {
        Task<List<T>> GetListAsync<T>(object query = null, string path = null, Dictionary<string, string> header = null);
        Task<T> GetAsync<T>(object entityId, string path = null);
        Task<T> GetByQueryAsync<T>(object query = null, string path = null);

        Task<T> PostAsync<T>(T entity, string path = null, object query = null);
        Task<string> PostAsyncReceiveString<T>(T entity, string path = null);
        Task<T> PostByQueryAsync<T>(T entity, string path = null);

        Task<T> PatchAsync<T>(object entityId, T entity, string path = null);
        Task<T> PutAsync<T>(object entityId, T entity, string path = null, object query = null);

        Task DeleteAsync(object entityId, string path = null);

        Task HandleErrorAsync(HttpCall call);
        Task HandleBeforeCallAsync(HttpCall call);
        Task HandleAfterCallAsync(HttpCall call);
        Task<T> PostAsyncService<T>(object body, string path = null);
    }
}
