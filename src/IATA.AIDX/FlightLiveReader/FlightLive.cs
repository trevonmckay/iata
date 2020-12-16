using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX.FlightLiveReader
{

    public class FlightLive : IFlightLive
    {
        private XmlSerializer _XmlSerializer;
        public FlightLive()
        {
            Type type = typeof(FlightLegNotificationRequest);
            this._XmlSerializer = new XmlSerializer(type);
        }

        public FlightLegNotificationRequest ParseDeiceMessage(XmlDocument xml)
        {
            if (xml == null)
            {
                throw new ArgumentNullException();
            }

            return new FlightLegNotificationRequest();
        }


        public FlightLegNotificationRequest ParseDeiceMessage(StreamReader streamReader)
        {
            try
            {
                if (streamReader == null)
                {
                    throw new ArgumentNullException();
                }

                var reader = new FlightXmlReader(streamReader);
                return (FlightLegNotificationRequest)this._XmlSerializer.Deserialize(reader);

            }
            catch (XmlException)
            {
                throw new Exception();
            }

        }       
    }
}
