using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Gateway.Constants;

namespace Gateway.API.Controllers
{
    [ApiController]
    public class TestDataController : Controller
    {
        
        public TestDataController()
        {
           
        }

        [HttpGet]
        [Route(DataRequestConstants.getTestDataPath)]
        public IEnumerable<string> TestGet()
        {
            return new[] { "Value 1", "Value 2" };
        }

        [HttpPost]
        [Route(DataRequestConstants.postTestDataPath)]
        public IEnumerable<string> TestPost([FromBody] TestPostData data)
        {
            return new[] { data.Value1, data.Value2 };
        }
    }
}
