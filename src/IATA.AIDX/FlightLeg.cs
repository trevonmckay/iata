using System.Xml.Serialization;

namespace IATA.AIDX
{
    public sealed class FlightLeg
    {
        public FlightLeg() { }

        public FlightLegIdentifier LegIdentifier { get; set; }

        public FlightLegData LegData { get; set; }
    }
}
