namespace IATA.AIDX.Common.Types.Error
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class ErrorsType
    {

        private ErrorType[] errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Error")]
        public ErrorType[] Error
        {
            get
            {
                return errorField;
            }
            set
            {
                errorField = value;
            }
        }
    }
}