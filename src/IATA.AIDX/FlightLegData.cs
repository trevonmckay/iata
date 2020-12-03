using IATA.AIDX.FlightStatusQualifier;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace IATA.AIDX
{
    public class FlightLegData
    {
        public FlightLegData() { }

        [XmlElement]
        public string ServiceType { get; set; }

        [XmlElement]
        public FlightOperationalStatus OperationalStatus { get; set; }

        [XmlElement]
        public List<CodeShareInfo> CodeShareInfo { get; set; }

        [XmlElement]
        public List<OperationTime> OperationTime { get; set; }

        [XmlElement]
        public AircraftInfo AircraftInfo { get; set; }

        [XmlElement]
        public List<CabinClass> CabinClass { get; set; }

        [XmlElement]
        public PublicFlightDisplay PublicFlightDisplay { get; set; }
    }
}
