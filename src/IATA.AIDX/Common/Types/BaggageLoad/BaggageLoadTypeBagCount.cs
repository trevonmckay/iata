namespace IATA.AIDX.Common.Types.BaggageLoad
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class BaggageLoadTypeBagCount
    {

        private string locationField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Location
        {
            get
            {
                return locationField;
            }
            set
            {
                locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText(DataType = "positiveInteger")]
        public string Value
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