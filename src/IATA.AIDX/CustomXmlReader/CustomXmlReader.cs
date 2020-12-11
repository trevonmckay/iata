using System.Xml;

namespace IATA.AIDX.CustomXmlReader
{
    public class CustomXmlReader : XmlTextReader
    {
        public CustomXmlReader(System.IO.TextReader reader) : base(reader)
        {

        }

        public override string NamespaceURI
        {
            get { return string.Empty; }
        }
    }

}
