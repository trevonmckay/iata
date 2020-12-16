using IATA.AIDX.Airport;
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
        public List<string> PlannedArrivalAptHistory { get; set; }

        [XmlElement]
        public List<FlightOperationalStatus> OperationalStatus { get; set; }

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

        [XmlElement]
        public OwnerAirline OwnerAirline { get; set; }

        [XmlElement]
        public AirportResources AirportResources { get; set; }

        [XmlElement]
        public List<FlightLegIdentifier> AssociatedFlightLegAircraft { get; set; }
    }
}
