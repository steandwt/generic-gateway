using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Client
{
    public interface IGatewayClient
    {
        public Task<TResponse> ExecuteGet<TResponse>(IGetDataRequest request);
        public Task<TResponse> ExecutePost<TRequestData, TResponse>(IPostDataRequest<TRequestData> request);
    }
}
