using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Nuki
{
    public static class WebApi
    {
        private static HttpClient _client;

        public static HttpClient Client
        {
            get => _client ?? InitializeClient();
            set => _client = value;
        }

        private static HttpClient InitializeClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.nuki.io/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Authorization.ApiToken}");
            _client = client;
            return client;
        }
    }
}
