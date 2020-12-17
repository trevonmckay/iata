using IATA.AIDX.Messages;

namespace IATA.AIDX.AIDXMessageManager.AIDXMessageReceiver
{
    public class FlightLegRQReceiver : IAIDXMessageReceiver
    {
        public IAIDX_FlightLegMessage ReceiveAIDXMessage()
        {
            return new IATA_AIDX_FlightLegRQ();
        }
    }
}
