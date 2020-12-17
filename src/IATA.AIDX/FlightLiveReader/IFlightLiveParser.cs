using System.IO;
using System.Xml;

namespace IATA.AIDX.FlightLiveReader
{


    public interface IFlightLiveParser
    {
        FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader);
    }
}
