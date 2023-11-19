using Microsoft.AspNetCore.Mvc;
using Models.Gateway.Constants;
using Models.Gateway.Responses.Lookups;
using Models.Gateway.Shared;

namespace Gateway.API.Controllers
{
    [ApiController]
    public class LookupController : Controller
    {

        [HttpGet]
        [Route(LookupsRequestConstants.getPeopleLookupPath)]
        public IEnumerable<GenericKeyValuePair> GetPeopleLookup()
        {
            return new List<GenericKeyValuePair>() {
                new GenericKeyValuePair(){ Key = "Person 1", Value = "John"},
                 new GenericKeyValuePair(){ Key = "Person 2", Value = "Amy"}
            };
        }

        [HttpGet]
        [Route(LookupsRequestConstants.getCatogoriesLookup)]
        public IEnumerable<CategoryLookup> GetCategoriesLookup()
        {
            return new List<CategoryLookup>(){
                new CategoryLookup()
                {
                    Id = "1",
                    CategoryCode = "Code1",
                    CategoryDescription = "Desc1"
                },
                 new CategoryLookup()
                {
                    Id = "2",
                    CategoryCode = "Code2",
                    CategoryDescription = "Desc2"
                }
            };
        }
    }
}
