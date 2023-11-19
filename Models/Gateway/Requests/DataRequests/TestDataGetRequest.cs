using Models.Gateway.Constants;
using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Requests.DataRequests
{
    public class TestDataGetRequest : IGetDataRequest
    {
        public string RequestPath { get; } = DataRequestConstants.getTestDataPath; 
    }
}
