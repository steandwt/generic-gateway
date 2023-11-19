using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Gateway.Client;
using Models.Gateway.Requests.Calculator;
using Models.Gateway.Requests.Lookups;
using Models.Gateway.Responses.Lookups;
using Models.Gateway.Shared;

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
        [Route("get-people-from-gateway")]
        public async Task<List<GenericKeyValuePair>> GetPeopleFromGateway()
        {
            return await _client.ExecuteGet<List<GenericKeyValuePair>>(new GetPeopleLookupRequest());
        }

        [HttpGet]
        [Route("get-categories")]
        public async Task<List<CategoryLookup>> GetCategoriesFromGateway()
        {
            return await _client.ExecuteGet<List<CategoryLookup>>(new GetCategoriesLookupRequest());
        }

        [HttpGet]
        [Route("get-calc-addition")]
        public async Task<int> GetCalculatorAddition()
        {
            return await _client.ExecutePost<CalculatorAdditionRequest, int>(new GetCalculatorAdditionaRequest()
            {
                RequestData = new CalculatorAdditionRequest
                {
                    Value1 = 5,
                    Value2 = 10
                }
            });
        }

    }
}
