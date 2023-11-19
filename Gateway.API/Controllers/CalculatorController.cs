using Microsoft.AspNetCore.Mvc;
using Models.Gateway.Constants;
using Models.Gateway.Requests.Calculator;

namespace Gateway.API.Controllers
{
    [ApiController]
    public class CalculatorController : Controller
    {

        [HttpPost]
        [Route(CalculatorRequestConstants.getCalculatorAdditionPath)]
        public int Add([FromBody] CalculatorAdditionRequest request)
        {
            return request.Value1 + request.Value2;
        }
    }
}
