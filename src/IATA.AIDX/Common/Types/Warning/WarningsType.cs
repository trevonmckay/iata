namespace IATA.AIDX.Common.Types.Warning
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
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