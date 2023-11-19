namespace Models.Gateway.Requests.BaseRequestModels
{
    public interface IPostDataRequest<TRequestData> : IBaseDataRequest
    {
        TRequestData RequestData { get; set; }
    }
}
