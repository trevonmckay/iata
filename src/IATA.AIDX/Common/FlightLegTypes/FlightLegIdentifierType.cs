namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegIdentifierType
    {

        private FlightLegIdentifierTypeAirline airlineField;

        private string flightNumberField;

        private string operationalSuffixField;

        private FlightLegIdentifierTypeDepartureAirport departureAirportField;

        private FlightLegIdentifierTypeArrivalAirport arrivalAirportField;

        private System.DateTime originDateField;

        private FlightLegIdentifierTypeRepeatNumber repeatNumberField;

        /// <remarks/>
        public FlightLegIdentifierTypeAirline Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        public string OperationalSuffix
        {
            get
            {
                return this.operationalSuffixField;
            }
            set
            {
                this.operationalSuffixField = value;
            }
        }

        /// <remarks/>
        public FlightLegIdentifierTypeDepartureAirport DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        public FlightLegIdentifierTypeArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OriginDate
        {
            get
            {
                return this.originDateField;
            }
            set
            {
                this.originDateField = value;
            }
        }

        /// <remarks/>
        public FlightLegIdentifierTypeRepeatNumber RepeatNumber
        {
            get
            {
                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }
    }
}