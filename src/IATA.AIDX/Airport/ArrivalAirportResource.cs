namespace IATA.AIDX.Airport
{
    public sealed class ArrivalAirportResource : IAirportResource
    {
        public const string DepartureOrArrival = "Arrival";

        public string AircraftTerminal { get; set; }

        public string PublicTerminal { get; set; }

        public string PassengerGate { get; set; }

        public string BaggageClaimUnit { get; set; }

        string IAirportResource.DepartureOrArrival => DepartureOrArrival;
    }
}
