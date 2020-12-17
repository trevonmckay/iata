using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX.FlightLiveReader
{
    /// <summary>
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
