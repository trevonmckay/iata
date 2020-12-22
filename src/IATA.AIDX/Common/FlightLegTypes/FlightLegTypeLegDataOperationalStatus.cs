namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataOperationalStatus
    {

        private string repeatIndexField;

        private string codeContextField;

        private FlightLegScopeType flightLegScopeField;

        private bool flightLegScopeFieldSpecified;

        private string valueField;

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
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightLegScopeType FlightLegScope
        {
            get
            {
                return this.flightLegScopeField;
            }
            set
            {
                this.flightLegScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlightLegScopeSpecified
        {
            get
            {
                return this.flightLegScopeFieldSpecified;
            }
            set
            {
                this.flightLegScopeFieldSpecified = value;
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