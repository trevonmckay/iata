using IATA.AIDX.Common.Types.Location;
using IATA.AIDX.Common.Types.Measurement;

namespace IATA.AIDX.Common.Types
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class DeadLoadType {
    
    private string typeField;
    
    private MeasurementType weightField;
    
    private DestinationType destinationTypeField;
    
    private bool destinationTypeFieldSpecified;
    
    /// <remarks/>
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public MeasurementType Weight {
        get {
            return this.weightField;
        }
        set {
            this.weightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DestinationType DestinationType {
        get {
            return this.destinationTypeField;
        }
        set {
            this.destinationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DestinationTypeSpecified {
        get {
            return this.destinationTypeFieldSpecified;
        }
        set {
            this.destinationTypeFieldSpecified = value;
        }
    }
}
}