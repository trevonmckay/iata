using IATA.AIDX.Common.Types;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataTechnicalStopInd
    {

        private DepartureArrivalType departureOrArrivalField;

        private bool departureOrArrivalFieldSpecified;

        private bool valueField;

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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepartureOrArrivalSpecified
        {
            get
            {
                return this.departureOrArrivalFieldSpecified;
            }
            set
            {
                this.departureOrArrivalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
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