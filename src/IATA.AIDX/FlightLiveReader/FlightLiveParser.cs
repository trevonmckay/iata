using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX.FlightLiveReader
{

    public class FlightLiveParser : IFlightLiveParser
    {
        private XmlSerializer _XmlSerializer;
        public FlightLiveParser()
        {
            Type type = typeof(FlightLegNotificationRequest);
            this._XmlSerializer = new XmlSerializer(type);
        }

        public FlightLegNotificationRequest ParseXMLMessage(XmlDocument xml)
        {
            if (xml == null)
            {
                throw new ArgumentNullException();
            }

            return new FlightLegNotificationRequest();
        }


        public FlightLegNotificationRequest ParseXMLMessage(StreamReader streamReader)
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
