namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeGeneralAviationLegIdentifierGeneralAviationIdentifier
    {

        private FlightLegTypeGeneralAviationLegIdentifierGeneralAviationIdentifierCategory categoryField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightLegTypeGeneralAviationLegIdentifierGeneralAviationIdentifierCategory Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
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