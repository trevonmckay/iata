namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class WarningsType {
    
    private WarningType[] warningField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Warning")]
    public WarningType[] Warning {
        get {
            return this.warningField;
        }
        set {
            this.warningField = value;
        }
    }
}
}