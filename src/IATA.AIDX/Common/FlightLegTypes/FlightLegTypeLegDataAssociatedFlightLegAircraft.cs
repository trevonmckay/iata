namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataAssociatedFlightLegAircraft : FlightLegIdentifierType
    {

        private string repeatIndexField;

        private FlightLegTypeLegDataAssociatedFlightLegAircraftFlightSequence flightSequenceField;

        private bool flightSequenceFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightLegTypeLegDataAssociatedFlightLegAircraftFlightSequence FlightSequence
        {
            get
            {
                return this.flightSequenceField;
            }
            set
            {
                this.flightSequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlightSequenceSpecified
        {
            get
            {
                return this.flightSequenceFieldSpecified;
            }
            set
            {
                this.flightSequenceFieldSpecified = value;
            }
        }
    }
}