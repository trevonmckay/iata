using System;

namespace IATA.AIDX
{
    public class FlightLegIdentifier
    {
        public FlightLegIdentifier() { }

        public string Airline { get; set; }

        public string FlightNumber { get; set; }

        public DateTime OriginDate { get; set; }

        public string DepartureAirport { get; set; }

        public string ArrivalAirport { get; set; }

        public int RepeatNumber { get; set; }
    }
}
