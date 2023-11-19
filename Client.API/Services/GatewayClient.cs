using Models.Gateway.Client;
using Models.Gateway.Requests.BaseRequestModels;
using System.Text.Json;

namespace Client.API.Services
{
    public class GatewayClient : IGatewayClient
    {
        private HttpClient _httpClient; 

        private JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public GatewayClient(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("GatewayHttpClient");   
        }

        public async Task<TResponse> ExecuteGet<TResponse>(IGetDataRequest request)
        {
            var httpResponse = await _httpClient.GetAsync(request.RequestPath);
            var result = await httpResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TResponse>(result, _jsonOptions);
        }

        public async Task<TResponse> ExecutePost<TRequestData, TResponse>(IPostDataRequest<TRequestData> request)
        {
            var jsonContent = JsonContent.Create(request.RequestData); 

            var httpResponse = await _httpClient.PostAsync(request.RequestPath, jsonContent);
            var result = await httpResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TResponse>(result, _jsonOptions);
        }
    }
}
