using IATA.AIDX.Common.Types;
using System.Xml.Serialization;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    // [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = true, Namespace = "http://www.iata.org/IATA/2007/00", TypeName = "FlightLeg")]
    [XmlRoot("FlightLeg")]
    public partial class FlightLegType
    {

        private object itemField;

        private System.Nullable<FlightLegTypeSpecialAction> specialActionField;

        private bool specialActionFieldSpecified;

        private FlightLegTypeLegData legDataField;

        private TPA_ExtensionsType tPA_ExtensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneralAviationLegIdentifier", typeof(FlightLegTypeGeneralAviationLegIdentifier))]
        [System.Xml.Serialization.XmlElementAttribute("LegIdentifier", typeof(FlightLegIdentifierType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<FlightLegTypeSpecialAction> SpecialAction
        {
            get
            {
                return this.specialActionField;
            }
            set
            {
                this.specialActionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecialActionSpecified
        {
            get
            {
                return this.specialActionFieldSpecified;
            }
            set
            {
                this.specialActionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LegData", typeof(FlightLegTypeLegData))]
        public FlightLegTypeLegData LegData
        {
            get
            {
                return this.legDataField;
            }
            set
            {
                this.legDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TPA_Extension")]
        public TPA_ExtensionsType TPA_Extension
        {
            get
            {
                return this.tPA_ExtensionField;
            }
            set
            {
                this.tPA_ExtensionField = value;
            }
        }
    }
}