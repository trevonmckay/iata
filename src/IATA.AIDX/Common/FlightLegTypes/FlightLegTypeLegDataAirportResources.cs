using IATA.AIDX.Common.Types;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataAirportResources
    {

        private FlightLegTypeLegDataAirportResourcesResource[] resourceField;

        private UsageType usageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resource")]
        public FlightLegTypeLegDataAirportResourcesResource[] Resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
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
    }
}