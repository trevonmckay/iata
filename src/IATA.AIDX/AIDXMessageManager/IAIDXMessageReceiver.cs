using IATA.AIDX.Messages;

namespace IATA.AIDX.AIDXMessageManager
{


    internal interface IAIDXMessageReceiver
    {
        /// <summary>
        /// Receiver receives AIDX message 
        /// </summary>
        /// <returns></returns>
        IAIDX_FlightLegMessage ReceiveAIDXMessage();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        // IATA_AIDX_FlightLegRS ReceiveAIDXAcknowledgement();

    }
}