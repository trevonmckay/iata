namespace IATA.AIDX.Common.Types.Fuel
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FuelQualifierType
    {

        private string extensionField;

        private FuelQualifierEnumType valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string extension
        {
            get
            {
                return extensionField;
            }
            set
            {
                extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public FuelQualifierEnumType Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }
}