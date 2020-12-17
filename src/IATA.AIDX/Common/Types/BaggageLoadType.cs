namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class BaggageLoadType {
    
    private BaggageLoadTypeBagCount[] bagCountField;
    
    private MeasurementType weightField;
    
    private string serviceClassField;
    
    private DestinationType destinationTypeField;
    
    private bool destinationTypeFieldSpecified;
    
    private string repeatIndexField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BagCount", IsNullable=true)]
    public BaggageLoadTypeBagCount[] BagCount {
        get {
            return this.bagCountField;
        }
        set {
            this.bagCountField = value;
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
    public string ServiceClass {
        get {
            return this.serviceClassField;
        }
        set {
            this.serviceClassField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RepeatIndex {
        get {
            return this.repeatIndexField;
        }
        set {
            this.repeatIndexField = value;
        }
    }
}
}