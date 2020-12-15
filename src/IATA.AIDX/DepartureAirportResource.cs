namespace IATA.AIDX
{
    public sealed class DepartureAirportResource : IAirportResource
    {
        public const string DepartureOrArrival = "Departure";

        public string AircraftTerminal { get; set; }

        public string PublicTerminal { get; set; }

        public string PassengerGate { get; set; }

        string IAirportResource.DepartureOrArrival => DepartureOrArrival;
    }
}
