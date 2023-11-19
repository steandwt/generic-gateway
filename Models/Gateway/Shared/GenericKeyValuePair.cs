namespace Models.Gateway.Shared
{
    public class GenericKeyValuePair : IGenericKeyValuePair<string, string>
    {
        public string Key { get; set;  }
        public string Value { get; set; }
    }
}
