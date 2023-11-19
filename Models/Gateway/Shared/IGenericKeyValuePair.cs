namespace Models.Gateway.Shared
{
    public interface IGenericKeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
