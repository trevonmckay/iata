using System;
using System.Xml.Serialization;

namespace IATA.AIDX
{
    [XmlRoot("IATA_AIDX_FlightLegNotifRQ")]
    public class FlightLegNotificationRequest
    {
        public FlightLegNotificationRequest() { }

        [XmlAttribute]
        public string CodeContext { get; set; }

        [XmlAttribute]
        public string Target { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "PrimaryLangID")]
        public string PrimaryLangId { get; set; }

        [XmlAttribute]
        public string TransactionStatusCode { get; set; }

        [XmlAttribute]
        public bool RetransmissionIndicator { get; set; }

        [XmlAttribute(AttributeName = "TimeStamp")]
        public DateTime Timestamp { get; set; }

        [XmlAttribute]
        public string TransactionIdentifier { get; set; }

        [XmlElement]
        public Originator Originator { get; set; }

        [XmlElement]
        public FlightLeg FlightLeg { get; set; }
    }
}
