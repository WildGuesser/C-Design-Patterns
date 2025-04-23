namespace Adapter
{
    // Target -> The interface the client wants to use
    public interface IJsonParser<T>
    {
        T Parse(string data);
        String ConvertToJson(T obj);
    }
}
