using Microsoft.AspNetCore.Mvc;
using Models;

namespace Gateway.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestDataController : Controller
    {
        
        public TestDataController()
        {
           
        }

        [HttpGet]
        [Route("test-get-data")]
        public IEnumerable<string> TestGet()
        {
            return new[] { "Value 1", "Value 2" };
        }

        [HttpPost]
        [Route("test-post-data")]
        public IEnumerable<string> TestPost([FromBody] TestPostData data)
        {
            return new[] { data.Value1, data.Value2 };
        }
    }
}
