namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class MeasurementType {
    
    private MeasurementUnitType measurementUnitField;
    
    private bool measurementUnitFieldSpecified;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public MeasurementUnitType MeasurementUnit {
        get {
            return this.measurementUnitField;
        }
        set {
            this.measurementUnitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MeasurementUnitSpecified {
        get {
            return this.measurementUnitFieldSpecified;
        }
        set {
            this.measurementUnitFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
}