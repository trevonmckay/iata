namespace IATA.AIDX.Common.Types
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iata.org/IATA/2007/00")]
public partial class FuelDataType {
    
    private FuelQualifierType typeField;
    
    private MeasurementType quantityField;
    
    /// <remarks/>
    public FuelQualifierType Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public MeasurementType Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}
}