using IATA.AIDX.Common.Types;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataCabinClassPaxCount
    {

        private string qualifierField;

        private UsageType usageField;

        private bool usageFieldSpecified;

        private string repeatIndexField;

        private DestinationType destinationTypeField;

        private bool destinationTypeFieldSpecified;

        private DCS_UsageType dCS_UsageField;

        private bool dCS_UsageFieldSpecified;

        private OriginationType originationTypeField;

        private bool originationTypeFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UsageType Usage
        {
            get
            {
                return this.usageField;
            }
            set
            {
                this.usageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UsageSpecified
        {
            get
            {
                return this.usageFieldSpecified;
            }
            set
            {
                this.usageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string RepeatIndex
        {
            get
            {
                return this.repeatIndexField;
            }
            set
            {
                this.repeatIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DestinationType DestinationType
        {
            get
            {
                return this.destinationTypeField;
            }
            set
            {
                this.destinationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DestinationTypeSpecified
        {
            get
            {
                return this.destinationTypeFieldSpecified;
            }
            set
            {
                this.destinationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DCS_UsageType DCS_Usage
        {
            get
            {
                return this.dCS_UsageField;
            }
            set
            {
                this.dCS_UsageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DCS_UsageSpecified
        {
            get
            {
                return this.dCS_UsageFieldSpecified;
            }
            set
            {
                this.dCS_UsageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OriginationType OriginationType
        {
            get
            {
                return this.originationTypeField;
            }
            set
            {
                this.originationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OriginationTypeSpecified
        {
            get
            {
                return this.originationTypeFieldSpecified;
            }
            set
            {
                this.originationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}