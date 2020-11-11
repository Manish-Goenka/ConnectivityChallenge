using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConnectivityChallenge.API
{
    public abstract class BaseAPI
    {
        private static HttpClient httpClient;

        private static HttpClient HttpClient
        {
            get
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Accept.Clear();

                    return httpClient;
                }

                return httpClient;
            }
        }

        public async Task<T> GetAsync<T>(string baseURI, string path)
        {
            using HttpResponseMessage resp = await HttpClient.GetAsync(baseURI + path);

            if (resp.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<T>(await resp.Content.ReadAsStringAsync());
            }

            throw new ApplicationException(await resp.Content.ReadAsStringAsync());
        }
    }
}
