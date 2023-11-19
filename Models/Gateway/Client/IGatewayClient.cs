using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Client
{
    public interface IGatewayClient
    {
        public Task<TResponse> Execute<TResponse>(IGetDataRequest request);
        public Task<TResponse> Execute<TRequestData, TResponse>(IPostDataRequest<TRequestData> request);
    }
}
