using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Gateway.Client;
using Models.Gateway.Requests.DataRequests;

namespace Client.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        public IGatewayClient _client;

        public DataController(IGatewayClient client)
        {
            _client = client;
        }

        [HttpGet]
        [Route("get-data-from-gateway")]
        public async Task<IEnumerable<string>> GetDataFromGateway()
        {
            return await _client.ExecuteGet<List<string>>(new TestDataGetRequest());
        }

        [HttpPost]
        [Route("post-data-to-gateway")]
        public async Task<IEnumerable<string>> PostDataToGateway()
        {
            return await _client.ExecutePost<TestPostData, List<string>>(new TestDataPostRequest<TestPostData>()
            {
                RequestData = new TestPostData()
                {
                    Value1 = "Value 1 from client",
                    Value2 = "Value 2 from client"
                }
            });
        }

    }
}
