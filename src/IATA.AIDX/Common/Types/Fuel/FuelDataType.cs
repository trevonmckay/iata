using IATA.AIDX.Common.Types.Measurement;

namespace IATA.AIDX.Common.Types.Fuel
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FuelDataType
    {

        private FuelQualifierType typeField;

        private MeasurementType quantityField;

        /// <remarks/>
        public FuelQualifierType Type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public MeasurementType Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }
    }
}