using Models.Gateway.Constants;
using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Requests.Lookups
{
    public class GetCategoriesLookupRequest : IGetDataRequest
    {
        public string RequestPath { get; } = LookupsRequestConstants.getCatogoriesLookup;
    }
}
