namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataOwnerAirline
    {

        private FlightLegTypeLegDataOwnerAirlineAirline airlineField;

        private string flightNumberField;

        private string operationalSuffixField;

        /// <remarks/>
        public FlightLegTypeLegDataOwnerAirlineAirline Airline
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
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
    }
}