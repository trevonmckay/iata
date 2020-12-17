namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class FuelQualifierType {
    
    private string extensionField;
    
    private FuelQualifierEnumType valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension {
        get {
            return this.extensionField;
        }
        set {
            this.extensionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public FuelQualifierEnumType Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
}