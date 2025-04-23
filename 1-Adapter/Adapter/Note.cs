using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    [Serializable, XmlRoot("note")]
    //  defines a data model for serializing and deserializing XML data.
    public class Note
    {
            [XmlElement("to")]
            public string To { get; set; }

            [XmlElement("from")]
            public string From { get; set; }

            [XmlElement("heading")]
            public string Heading { get; set; }

            [XmlElement("body")]
            public string Body { get; set; }
        
    }
}
