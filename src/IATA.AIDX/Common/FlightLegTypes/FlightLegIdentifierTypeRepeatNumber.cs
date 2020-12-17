namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegIdentifierTypeRepeatNumber
    {

        private bool currentIndField;

        private bool currentIndFieldSpecified;

        private string airborneReturnNumberField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CurrentInd
        {
            get
            {
                return this.currentIndField;
            }
            set
            {
                this.currentIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentIndSpecified
        {
            get
            {
                return this.currentIndFieldSpecified;
            }
            set
            {
                this.currentIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string AirborneReturnNumber
        {
            get
            {
                return this.airborneReturnNumberField;
            }
            set
            {
                this.airborneReturnNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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