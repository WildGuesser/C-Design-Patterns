
namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

            IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
            Note note = parser.Parse(someXml);
            Console.WriteLine(parser.ConvertToJson(note));

        }
    }
}
