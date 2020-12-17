using System.IO;
using System.Xml;

namespace IATA.AIDX.FlightLiveReader
{
    /// <summary>
    /// 
    /// In general, each time a data sender composes and sends an AIDX message it shall be subject
    /// to XML validation before the message is transmitted.
    /// In general, each time a receiver receives an AIDX message it should be subject to schema
    /// validation.
    /// **************************************************************************************************
    /// 1. Receive FlightLegNotifRQ
    /// 
    /// 2. Send FlightLegRQ
    /// IATA_AIDX_FlightLegRQ is used to request flight data records from a partner (i.e. airline or 
    /// data aggregator
    /// 
    /// 3. Send FlightLegRS (SYNC) (Could be success or failure)
    /// IATA_AIDX_FlightLegRS is used as an acknowledgement message to be returned as a
    /// response to a notification(IATA_AIDX_FlightLegNotifRQ) or a synchronous response to a
    /// flight data request(IATA_AIDX_FlightLegRQ)
    /// 
    /// 4. Send FlightLegNotifRQ (ASYNC)
    /// </summary>
    /// 

    public interface IFlightLiveParser
    {
        FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader);
    }
}
