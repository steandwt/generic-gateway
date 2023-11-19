using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Requests.DataRequests
{
    public class TestDataPostRequest<TRequestData> : IPostDataRequest<TRequestData>
    {
        public string RequestPath { get; } = "api/testData/test-post-data";
        public TRequestData? RequestData { get; set; }
    }
}
