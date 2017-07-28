Another approach to the class hierarchy, in case I need more flexibility in the future.

```csharp
using AccountingLiveApiClient.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace AccountingLiveApiClient.Test
{
    public class BaseConsumer
    {
        private readonly Fetch _fetch;

        public BaseConsumer(Fetch fetch)
        {
            _fetch = fetch;
        }

        public async Task<T> GetAsync<T>(string path) where T : class
        {
            string body = await _fetch.GetAsync(path);
            EnsureResponseStatus(body);
            return JsonConvert.DeserializeObject<T>(body);
        }

        public async Task<string> CreateAsync<T>(string path, T resource) where T : class
        {
            string body = await _fetch.PostAsync(path, resource);
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
                // If can't deserialize to ApiResponse<string>, the response body doesn't have the form of an error, so ignore it
                return Status.ok.ToString();
            }
        }
    }

    public sealed class ItemsConsumer : BaseConsumer
    {
        public ItemsConsumer(Fetch fetch) : base(fetch)
        {
        }

        public async Task<Item[]> GetAsync() => (await GetAsync<ApiResponse<Item[]>>("items")).data;

        /// <summary>
        /// Creates a new <see cref="item"/>.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Returns the <see cref="Item.ID"/> of the created <paramref name="item"/></returns>
        public async Task<string> CreateAsync(Item item) => await CreateAsync("items", item);
    }

    public sealed class ApiConsumer
    {
        private readonly Fetch _fetch;

        private ItemsConsumer _itemsConsumerInstance;

        public ApiConsumer(string uri, string username, string companyID, string password)
        {
            _fetch = new Fetch(uri, $"{username}:{companyID}:{password}");
        }

        public ItemsConsumer ItemsConsumer
        {
            get
            {
                if (_itemsConsumerInstance == null)
                {
                    _itemsConsumerInstance = new ItemsConsumer(_fetch);
                }
                return _itemsConsumerInstance;
            }
        }
    }
}
```