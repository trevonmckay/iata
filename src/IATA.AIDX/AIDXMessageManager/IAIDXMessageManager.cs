using System;
using System.IO;
using System.Xml;

namespace IATA.AIDX.AIDXMessageManager
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAIDXMessageManager : IDisposable
    {
        FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader);
        /// <summary>
        /// Transform a XML's Stream into a T type
        /// </summary>
        /// <typeparam name="T">Define the type of message that will returned (IATA_AIDX_FlightLegNotifRQ, IATA_AIDX_FlightLegRQ, or IATA_AIDX_FlightLegRS)</typeparam>
        /// <param name="streamReader"> Stream of XML</param>
        /// <returns></returns>
        T ParseAIDXXMLMessage<T>(StreamReader streamReader) where T : class;
    }
}
