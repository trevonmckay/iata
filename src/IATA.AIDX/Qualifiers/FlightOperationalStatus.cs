using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace IATA.AIDX.FlightStatusQualifier
{

    /// <summary>
    /// This provides the current operational status of a flight
    /// </summary>
    public class FlightOperationalStatus : IXmlSerializable
    {
        public static FlightOperationalStatus AirborneDeparted = new FlightOperationalStatus("TKO", "Airborne / Departed", "9750");
        public static FlightOperationalStatus Boarding = new FlightOperationalStatus("BST", "Boarding", "9750");
        public static FlightOperationalStatus DeIcingInProgress = new FlightOperationalStatus("DIC", "De-icing in progress", "9750");
        public static FlightOperationalStatus DomesticFlight = new FlightOperationalStatus("7DO", "Domestic flight - version 11.1 and earlier", "1245");
        public static FlightOperationalStatus FinalApproach = new FlightOperationalStatus("FIN", "Final approach", "9750");
        public static FlightOperationalStatus FlightCancelled = new FlightOperationalStatus("DX", "Flight cancelled", "2005");
        public static FlightOperationalStatus FlightDiverted = new FlightOperationalStatus("DV", "Flight diverted", "2005");        
        public static FlightOperationalStatus FlightEnteredLocalRegion = new FlightOperationalStatus("FIR", "Flight entered local Flight Information Region", "9750");
        public static FlightOperationalStatus GroundReturn = new FlightOperationalStatus("GRT", "Ground Return", "2005");
        public static FlightOperationalStatus Initiated = new FlightOperationalStatus("INI", "Initiated (Flight Plan activated", "9750");
        public static FlightOperationalStatus InternationFlight = new FlightOperationalStatus("7IN", "International flight - version 11.1 and earlier", "1245");
        public static FlightOperationalStatus Landed = new FlightOperationalStatus("LAN", "Landed", "9750");
        public static FlightOperationalStatus NonOperationalFlight = new FlightOperationalStatus("NOP", "Non-Opertional flight", "1245");
        public static FlightOperationalStatus OperationalFlight = new FlightOperationalStatus("OP", "Operational Flight", "1245");
        public static FlightOperationalStatus OffBlock = new FlightOperationalStatus("OFB", "Off Block", "9750");
        public static FlightOperationalStatus OnBlock = new FlightOperationalStatus("ONB", "On block", "9750");
        public static FlightOperationalStatus ReadyForStart = new FlightOperationalStatus("RDT", "Ready for start", "9750");
        public static FlightOperationalStatus ReadyForDeIcing = new FlightOperationalStatus("DIR", "Ready for de-icing", "9750");
        public static FlightOperationalStatus ReInstate = new FlightOperationalStatus("SQ", "Re-instate a cancelled or diverted flight", "1245");
        public static FlightOperationalStatus ReRoute = new FlightOperationalStatus("RT", "Re-route", "2005");
        public static FlightOperationalStatus Scheduled = new FlightOperationalStatus("SCH", "Scheduled", "9750");      
        public static FlightOperationalStatus Sequenced = new FlightOperationalStatus("SEQ", "Sequenced (TSAT issued)", "9750");
          
        public static IEnumerable<FlightOperationalStatus> GetAll()
        {
            var fields = typeof(FlightOperationalStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            return fields.Select(f => f.GetValue(null)).Cast<FlightOperationalStatus>();
        }

        public static bool TryParse(string value, out FlightOperationalStatus operationalStatus)
        {
            var operationalStatuses = GetAll();
            var codes = operationalStatuses.ToDictionary(s => s.Code, s => s, StringComparer.OrdinalIgnoreCase);
            if (codes.ContainsKey(value))
            {
                operationalStatus = codes[value];
                return true;
            }

            operationalStatus = null;
            return false;
        }

        private FlightOperationalStatus(string codeValue, string meaning, string padisCodesetReference)
        {
            Code = codeValue;
            Description = meaning;
            PadisCodesetReference = padisCodesetReference;
        }

        private FlightOperationalStatus() { }

        public string Code { get; private set; }

        public string Description { get; private set; }

        public string PadisCodesetReference { get; private set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var value = reader.ReadInnerXml();
            if (TryParse(value, out FlightOperationalStatus operationalStatus))
            {
                Code = operationalStatus.Code;
                Description = operationalStatus.Description;
                PadisCodesetReference = operationalStatus.PadisCodesetReference;
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("OperationalStatus", this.Code);
            writer.WriteAttributeString("CodeContext", this.PadisCodesetReference);
        }
    }
}
