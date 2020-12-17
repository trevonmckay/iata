using System.IO;
using System.Xml;

namespace IATA.AIDX.AIDXMessageManager
{
    public interface IAIDXMessageManager
    {
        FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader);
    }
}
