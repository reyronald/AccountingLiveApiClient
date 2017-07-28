using AccountingLiveApiClient.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AccountingLiveApiClient
{
    public sealed class BaseConsumer<TResource> where TResource : class
    {
        private readonly Fetch _fetch;
        private string _path;

        public BaseConsumer(Fetch fetch, string path)
        {
            _fetch = fetch;
            _path = path;
        }

        public async Task<TResource[]> GetAsync()
        {
            string body = await _fetch.GetAsync(_path);
            EnsureResponseStatus(body);
            return JsonConvert.DeserializeObject<ApiResponse<TResource[]>>(body).data;
        }

        public async Task<string> CreateAsync(TResource resource)
        {
            string body = await _fetch.PostAsync(_path, resource);
            return EnsureResponseStatus(body);
        }

        private static string EnsureResponseStatus(string body)
        {
            try
            {
                ApiResponse<string> response = JsonConvert.DeserializeObject<ApiResponse<string>>(body);
                if (response.status != Status.ok)
                {
                    throw new HttpRequestException(response.data);
                }
                return response.data;
            }
            catch (JsonReaderException)
            {
                // If can't deserialize to ApiResponse<string>, 
                // the response body doesn't have the form of an error, so ignore it
                return nameof(Status.ok);
            }
        }
    }
}