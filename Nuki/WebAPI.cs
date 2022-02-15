using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Nuki
{
    public static class WebAPI
    {
        private static HttpClient _client;

        public static HttpClient Client
        {
            get { return _client ?? InitializeClient(); }
        }

        private static HttpClient InitializeClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.nuki.io/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Authorization.ApiToken}");
            return client;
        }
    }
}
