namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataRemarkFreeText
    {

        private FlightLegScopeType fllightLegScopeField;

        private bool fllightLegScopeFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightLegScopeType FllightLegScope
        {
            get
            {
                return this.fllightLegScopeField;
            }
            set
            {
                this.fllightLegScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FllightLegScopeSpecified
        {
            get
            {
                return this.fllightLegScopeFieldSpecified;
            }
            set
            {
                this.fllightLegScopeFieldSpecified = value;
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