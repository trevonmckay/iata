using IATA.AIDX.Common.Types.Error;
using IATA.AIDX.Common.Types.Warning;

namespace IATA.AIDX.Common.Types
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WarningType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class FreeTextType {
    
    private string languageField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
}