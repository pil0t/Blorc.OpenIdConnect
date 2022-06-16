﻿namespace Blorc.OpenIdConnect
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using JsonSerializer = System.Text.Json.JsonSerializer;

    [ObsoleteEx(ReplacementTypeOrMember = $"{nameof(HttpClientBuilderExtensions.AddAccessToken)} or {nameof(HttpClientBuilderExtensions.CustomizeHttpRequestMessage)}", RemoveInVersion = "2.0.0")]
    public class TokenBasedSecuredHttpClient : IHttpClient
    {
        private readonly HttpClient _httpClient;

        private readonly IUserManager _userManager;

        public TokenBasedSecuredHttpClient(HttpClient httpClient, IUserManager userManager)
        {
            _httpClient = httpClient;
            _userManager = userManager;
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public async Task<T> GetAsNewtonsoftJsonAsync<T>(string requestUri)
        {
            await SetBearerTokenAsync();
            return JsonConvert.DeserializeObject<T>(await _httpClient.GetStringAsync(requestUri));
        }

        public async Task<T> GetAsNewtonsoftJsonAsync<T>(string requestUri, JsonSerializerSettings settings)
        {
            await SetBearerTokenAsync();
            return JsonConvert.DeserializeObject<T>(await _httpClient.GetStringAsync(requestUri), settings);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, completionOption);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, completionOption);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetAsync(requestUri, cancellationToken);
        }

        public async Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetByteArrayAsync(requestUri);
        }

        public async Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetByteArrayAsync(requestUri);
        }

        public async Task<T> GetJsonAsync<T>(string requestUri)
        {
            await SetBearerTokenAsync();
            return JsonSerializer.Deserialize<T>(await _httpClient.GetStringAsync(requestUri));
        }

        public async Task<T> GetJsonAsync<T>(string requestUri, JsonSerializerOptions options)
        {
            await SetBearerTokenAsync();
            return JsonSerializer.Deserialize<T>(await _httpClient.GetStringAsync(requestUri), options);
        }

        public async Task<Stream> GetStreamAsync(string requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetStreamAsync(requestUri);
        }

        public async Task<Stream> GetStreamAsync(Uri requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetStreamAsync(requestUri);
        }

        public async Task<string> GetStringAsync(string requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetStringAsync(requestUri);
        }

        public async Task<string> GetStringAsync(Uri requestUri)
        {
            await SetBearerTokenAsync();
            return await _httpClient.GetStringAsync(requestUri);
        }

        public async Task<HttpResponseMessage> PostAsJsonAsync<TValue>(
            Uri requestUri,
            TValue value,
            CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PostAsJsonAsync(requestUri, value, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsNewtonsoftJsonAsync<TValue>(string requestUri, TValue value)
        {
            await SetBearerTokenAsync();
            using (var stringContent = new StringContent(JsonConvert.SerializeObject(value)))
            {
                return await _httpClient.PostAsync(requestUri, stringContent);
            }
        }

        public async Task<HttpResponseMessage> PostAsNewtonsoftJsonAsync<TValue>(string requestUri, TValue value, JsonSerializerSettings settings)
        {
            await SetBearerTokenAsync();
            using (var stringContent = new StringContent(JsonConvert.SerializeObject(value, settings)))
            {
                return await _httpClient.PostAsync(requestUri, stringContent);
            }
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsJsonAsync<TValue>(Uri requestUri, TValue value, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PutAsJsonAsync(requestUri, value, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsNewtonsoftJsonAsync<TValue>(string requestUri, TValue value)
        {
            await SetBearerTokenAsync();
            using (var stringContent = new StringContent(JsonConvert.SerializeObject(value)))
            {
                return await _httpClient.PutAsync(requestUri, stringContent);
            }
        }

        public async Task<HttpResponseMessage> PutAsNewtonsoftJsonAsync<TValue>(string requestUri, TValue value, JsonSerializerSettings settings)
        {
            await SetBearerTokenAsync();
            using (var stringContent = new StringContent(JsonConvert.SerializeObject(value, settings)))
            {
                return await _httpClient.PutAsync(requestUri, stringContent);
            }
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            await SetBearerTokenAsync();
            return await _httpClient.SendAsync(request);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            await SetBearerTokenAsync();
            return await _httpClient.SendAsync(request, completionOption);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.SendAsync(request, completionOption, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await SetBearerTokenAsync();
            return await _httpClient.SendAsync(request, cancellationToken);
        }

        private async Task SetBearerTokenAsync()
        {
            if (await _userManager.IsAuthenticatedAsync())
            {
                var user = await _userManager.GetUserAsync();

                _httpClient.SetBearerToken(user.AccessToken);
            }
        }
    }
}
