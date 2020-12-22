using IATA.AIDX.Common.Types.Location;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataAircraftInfoAgentInfo
    {

        private string qualifierField;

        private DepartureArrivalType departureOrArrivalField;

        private string repeatIndexField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DepartureArrivalType DepartureOrArrival
        {
            get
            {
                return this.departureOrArrivalField;
            }
            set
            {
                this.departureOrArrivalField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}