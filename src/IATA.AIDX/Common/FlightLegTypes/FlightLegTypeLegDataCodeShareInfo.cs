namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataCodeShareInfo
    {

        private FlightLegTypeLegDataCodeShareInfoAirline airlineField;

        private string flightNumberField;

        private System.DateTime originationDateField;

        private bool originationDateFieldSpecified;

        private string sharedAllianceField;

        private string repeatIndexField;

        /// <remarks/>
        public FlightLegTypeLegDataCodeShareInfoAirline Airline
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OriginationDate
        {
            get
            {
                return this.originationDateField;
            }
            set
            {
                this.originationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OriginationDateSpecified
        {
            get
            {
                return this.originationDateFieldSpecified;
            }
            set
            {
                this.originationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string SharedAlliance
        {
            get
            {
                return this.sharedAllianceField;
            }
            set
            {
                this.sharedAllianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string RepeatIndex
        {
            get
            {
                return this.repeatIndexField;
            }
            set
            {
                this.repeatIndexField = value;
            }
        }
    }
}