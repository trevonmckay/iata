using System;
using System.IO;
using System.Xml;

namespace IATA.AIDX.AIDXMessageManager
{
    public interface IAIDXMessageManager : IDisposable
    {
        FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader);
        T ParseAIDXXMLMessage<T>(StreamReader streamReader) where T : class;
    }
}
