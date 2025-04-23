namespace Adapter
{
    public class XmlToJsonAdapter <T> : IJsonParser<T>
    {
        public T Parse ( string data)
        {
            IXmlParser<T>  xmlParser = new XmlParser<T> (); 

            return xmlParser.Parse (data);
        }

        public string ConvertToJson(T Obj)
        {
            IJsonParser <T> jsonParser = new JsonParser<T> ();  
            return jsonParser.ConvertToJson (Obj);
        }
    }
}
