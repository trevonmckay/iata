namespace IATA.AIDX.Airport
{
    public interface IAirportResource
    {
        string DepartureOrArrival { get; }

        string AircraftTerminal { get; }

        string PublicTerminal { get; }

        string PassengerGate { get; }
    }
}
