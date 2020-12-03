using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX
{
    public sealed class AirportResources : IXmlSerializable
    {
        public string Usage { get; set; }

        public ICollection<IAirportResource> Resource { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Usage = reader.GetAttribute("Usage");
            Resource = new List<IAirportResource>();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("AirportResources");
            foreach (var airportResoure in Resource)
            {
                if (airportResoure is IXmlSerializable xmlSerializable)
                {
                    xmlSerializable.WriteXml(writer);
                }
            }
            writer.WriteEndElement();
        }
    }
}
