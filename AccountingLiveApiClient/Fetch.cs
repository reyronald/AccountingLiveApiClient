using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AccountingLiveApiClient
{
    // https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

    public sealed class Fetch
    {
        private readonly HttpClient _client = new HttpClient();

        public Fetch(string uri, string credentials)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(credentials);

            // var uriBuilder = new UriBuilder(_request.Uri);
            // client.BaseAddress = uriBuilder.Uri;

            _client.BaseAddress = new Uri(uri);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task<string> GetAsync(string path)
        {
            HttpResponseMessage response = await _client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PostAsync<T>(string path, T resource) where T : class
        {
            string json = JsonConvert.SerializeObject(resource);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(path, stringContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}