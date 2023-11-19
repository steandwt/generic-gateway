namespace Models.Gateway.Constants
{
    public static class DataRequestConstants
    {
        private const string _basePath = "api/testData/";

        public const string getTestDataPath = $"{_basePath}test-get-data";
        public const string postTestDataPath = $"{_basePath}test-post-data";
    }
}
