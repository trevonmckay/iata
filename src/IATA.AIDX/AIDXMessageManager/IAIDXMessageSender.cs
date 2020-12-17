using IATA.AIDX.Messages;
using System.Threading.Tasks;

namespace IATA.AIDX.AIDXMessageManager
{

    internal interface IAIDXMessageSender
    {
        /// <summary>
        /// IATA_AIDX_FlightLegRQ is used to send flight data records 
        /// from a sender (i.e. Airport, Vendor, etc)
        /// to partner (i.e. Airline, Data aggregator, etc)
        /// </summary>
        /// <param name="notification"> A IATA_AIDX_FlightLegNotifRQ object.</param>
        void SendAIDXMessage(IATA_AIDX_FlightLegNotifRQ notification);



        /// <summary>
        ///
        /// </summary>
        /// <param name="acknoledgement"></param>
        void SendAIDXAcknowledgement(IATA_AIDX_FlightLegRS acknoledgement);



        /// <summary>
        /// Send FlightLegRS (SYNC) (Could be success or failure)
        /// IATA_AIDX_FlightLegRS is used as an acknowledgement message to be returned as a
        /// response to a notification(IATA_AIDX_FlightLegNotifRQ) or a synchronous response to a
        /// flight data request(IATA_AIDX_FlightLegRQ)
        /// </summary>
        /// <param name="request">A IATA_AIDX_FlightLegRQ object</param>
        void SendAIDXRequestMessage(IATA_AIDX_FlightLegRQ request);



        /// <summary>
        /// Send FlightLegNotifRQ asyncronous
        /// </summary>
        /// <param name="notification"></param>
        /// <returns></returns>

        Task SendAIDXAcknowledgementAsync(IATA_AIDX_FlightLegNotifRQ notification);

    }
}