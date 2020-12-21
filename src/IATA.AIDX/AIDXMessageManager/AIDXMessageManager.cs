using IATA.AIDX.Common.Exceptions;
using IATA.AIDX.CustomXmlReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX.AIDXMessageManager
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

    public class AIDXMessageManager : IAIDXMessageManager, IAIDXMessageValidator
    {
        private readonly XmlReaderSettings _Settings;
        private XmlSerializer _XmlSerializer;

        public AIDXMessageManager()
        {
            this._Settings = new XmlReaderSettings();
            ConfigureXMLSettings();

            Type type = typeof(FlightLegNotificationRequest);
            this._XmlSerializer = new XmlSerializer(type);
        }

        private void ConfigureXMLSettings()
        {
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            _Settings.IgnoreComments = true;
            _Settings.IgnoreProcessingInstructions = true;
            _Settings.IgnoreWhitespace = true;
            _Settings.ValidationType = ValidationType.Schema;
            _Settings.ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings;

            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_SimpleTypes.xsd");
            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_AIDX_CommonTypes.xsd");
            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_CommonTypes.xsd");
            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_AIDX_FlightLegNotifRQ.xsd");
            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_AIDX_FlightLegRQ.xsd");
            _Settings.Schemas.Add("http://www.iata.org/IATA/2007/00", $"{path}\\IATA_AIDX_FlightLegRS.xsd");

            _Settings.ValidationEventHandler += new ValidationEventHandler(this.ValidationEventHandler);

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
                throw;
            }

        }

        public T ParseAIDXXMLMessage<T>(StreamReader streamReader) where T : class
        {
            try
            {
                return Read<T>(streamReader);
            }
            catch (XmlException)
            {
                throw;
            }
        }



        internal T Read<T>(StreamReader xmlInputStream) where T : class
        {

            if (xmlInputStream == null)
            {
                throw new ArgumentNullException();
            }
            // create an instance of the XmlSerializer class, 
            // specifying the type of object to be deserialized.
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = typeof(T).Name;
            xRoot.IsNullable = false;
            XmlSerializer serializer = new XmlSerializer(typeof(T), xRoot);

            var reader = new FlightXmlReader(xmlInputStream);
            return (T)serializer.Deserialize(reader);
        }


        public void ValidateAIDXXMLMessage(XmlDocument document)
        {
            document.Validate(this.ValidationEventHandler);
        }


        public IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(string inputXml, bool includeHelperSchema)
        {
            var streamReader = new StreamReader(inputXml);
            return this.ValidateAIDXXMLMessage(streamReader, includeHelperSchema); ;
        }

        public IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(StreamReader inputXml, bool includeHelperSchema)
        {
            var events = new List<ValidationEventArgs>();
            _Settings.ValidationEventHandler += (s, e) => { events.Add(e); };

            using (var reader = XmlReader.Create(inputXml, _Settings))
            {

                while (reader.Read())
                    ;
            }

            return events;
        }

        public void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    new AIDXSchemeException(e.Message);
                    break;
                case XmlSeverityType.Warning:
                    //new AIDXSchemeException($"Warning: {e.Message}");
                    //log what happened
                    break;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
