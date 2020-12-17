namespace IATA.AIDX.Common.Types.Warning
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class WarningsType
    {

        private WarningType[] warningField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Warning")]
        public WarningType[] Warning
        {
            get
            {
                return warningField;
            }
            set
            {
                warningField = value;
            }
        }
    }
}