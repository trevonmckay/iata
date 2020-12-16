using System.IO;
using System.Xml;

namespace IATA.AIDX.FlightLiveReader
{
    public interface IFlightLive
    {
        FlightLegNotificationRequest ParseDeiceMessage(XmlDocument xml);
        FlightLegNotificationRequest ParseDeiceMessage(StreamReader streamReader);
    }
}
