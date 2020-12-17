using System.Xml.Serialization;

namespace IATA.AIDX
{
    public sealed class Originator
    {
        public Originator() { }

        [XmlAttribute]
        public string CompanyShortName { get; set; }

        [XmlAttribute]
        public string TravelSector { get; set; }

        [XmlAttribute]
        public string Code { get; set; }

        [XmlAttribute]
        public string CodeContext { get; set; }
    }
}
