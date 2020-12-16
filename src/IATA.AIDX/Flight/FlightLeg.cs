using System.Xml.Serialization;

namespace IATA.AIDX
{
    public sealed class FlightLeg
    {
        public FlightLeg() { }

        public string SpecialAction { get; set; }

        public FlightLegIdentifier LegIdentifier { get; set; }

        public FlightLegData LegData { get; set; }
    }
}
