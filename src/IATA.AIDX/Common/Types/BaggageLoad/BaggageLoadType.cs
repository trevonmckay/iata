using IATA.AIDX.Common.Types.Location;
using IATA.AIDX.Common.Types.Measurement;

namespace IATA.AIDX.Common.Types.BaggageLoad
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class BaggageLoadType
    {

        private BaggageLoadTypeBagCount[] bagCountField;

        private MeasurementType weightField;

        private string serviceClassField;

        private DestinationType destinationTypeField;

        private bool destinationTypeFieldSpecified;

        private string repeatIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("BagCount", IsNullable = true)]
        public BaggageLoadTypeBagCount[] BagCount
        {
            get
            {
                return bagCountField;
            }
            set
            {
                bagCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public MeasurementType Weight
        {
            get
            {
                return weightField;
            }
            set
            {
                weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ServiceClass
        {
            get
            {
                return serviceClassField;
            }
            set
            {
                serviceClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public DestinationType DestinationType
        {
            get
            {
                return destinationTypeField;
            }
            set
            {
                destinationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool DestinationTypeSpecified
        {
            get
            {
                return destinationTypeFieldSpecified;
            }
            set
            {
                destinationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RepeatIndex
        {
            get
            {
                return repeatIndexField;
            }
            set
            {
                repeatIndexField = value;
            }
        }
    }
}