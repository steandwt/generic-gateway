namespace Models.Gateway.Constants
{
    public static class DataRequestConstants
    {
        private static string _basePath = "api/testData/";

        public static string getTestDataPath = $"{_basePath}test-get-data";
        public static string postTestDataPath = $"{_basePath}test-post-data";
    }
}
