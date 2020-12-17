namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class WarningType : FreeTextType {
    
    private string typeField;
    
    private string shortTextField;
    
    private string codeField;
    
    private string docURLField;
    
    private string statusField;
    
    private string tagField;
    
    private string recordIDField;
    
    private string ownerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ShortText {
        get {
            return this.shortTextField;
        }
        set {
            this.shortTextField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string DocURL {
        get {
            return this.docURLField;
        }
        set {
            this.docURLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Tag {
        get {
            return this.tagField;
        }
        set {
            this.tagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RecordID {
        get {
            return this.recordIDField;
        }
        set {
            this.recordIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Owner {
        get {
            return this.ownerField;
        }
        set {
            this.ownerField = value;
        }
    }
}
}