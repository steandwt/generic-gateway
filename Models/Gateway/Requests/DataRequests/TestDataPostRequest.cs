using Models.Gateway.Constants;
using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Requests.DataRequests
{
    public class TestDataPostRequest<TRequestData> : IPostDataRequest<TRequestData>
    {
        public string RequestPath { get; } = DataRequestConstants.postTestDataPath; 
        public TRequestData? RequestData { get; set; }
    }
}
