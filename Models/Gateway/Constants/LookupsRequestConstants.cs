namespace Models.Gateway.Constants
{
    public static class LookupsRequestConstants
    {
        private const string _basePath = "api/lookup/";

        public const string getPeopleLookupPath = $"{_basePath}get-people";
        public const string getCatogoriesLookup = $"{_basePath}get-catagories";
    }
}
