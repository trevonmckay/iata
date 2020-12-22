namespace IATA.AIDX.Common.Types.Measurement
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class MeasurementType
    {

        private MeasurementUnitType measurementUnitField;

        private bool measurementUnitFieldSpecified;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public MeasurementUnitType MeasurementUnit
        {
            get
            {
                return measurementUnitField;
            }
            set
            {
                measurementUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool MeasurementUnitSpecified
        {
            get
            {
                return measurementUnitFieldSpecified;
            }
            set
            {
                measurementUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public decimal Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }
}