namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class ErrorsType {
    
    private ErrorType[] errorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error")]
    public ErrorType[] Error {
        get {
            return this.errorField;
        }
        set {
            this.errorField = value;
        }
    }
}
}