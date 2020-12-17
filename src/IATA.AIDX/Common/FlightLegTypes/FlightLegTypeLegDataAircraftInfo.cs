using IATA.AIDX.Common.Types;
using IATA.AIDX.Common.Types.BaggageLoad;
using IATA.AIDX.Common.Types.Fuel;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataAircraftInfo
    {

        private FlightLegTypeLegDataAircraftInfoAircraftType[] aircraftTypeField;

        private string aircraftSubTypeField;

        private string registrationField;

        private string tailNumberField;

        private FlightLegTypeLegDataAircraftInfoCrewInfo[] crewInfoField;

        private FlightLegTypeLegDataAircraftInfoAgentInfo[] agentInfoField;

        private string fleetNumberField;

        private string callSignField;

        private DeadLoadType[] deadLoadField;

        private BaggageLoadType[] baggageField;

        private FuelDataType[] fuelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AircraftType", IsNullable = true)]
        public FlightLegTypeLegDataAircraftInfoAircraftType[] AircraftType
        {
            get
            {
                return this.aircraftTypeField;
            }
            set
            {
                this.aircraftTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AircraftSubType
        {
            get
            {
                return this.aircraftSubTypeField;
            }
            set
            {
                this.aircraftSubTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Registration
        {
            get
            {
                return this.registrationField;
            }
            set
            {
                this.registrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TailNumber
        {
            get
            {
                return this.tailNumberField;
            }
            set
            {
                this.tailNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CrewInfo", IsNullable = true)]
        public FlightLegTypeLegDataAircraftInfoCrewInfo[] CrewInfo
        {
            get
            {
                return this.crewInfoField;
            }
            set
            {
                this.crewInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AgentInfo", IsNullable = true)]
        public FlightLegTypeLegDataAircraftInfoAgentInfo[] AgentInfo
        {
            get
            {
                return this.agentInfoField;
            }
            set
            {
                this.agentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FleetNumber
        {
            get
            {
                return this.fleetNumberField;
            }
            set
            {
                this.fleetNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CallSign
        {
            get
            {
                return this.callSignField;
            }
            set
            {
                this.callSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeadLoad")]
        public DeadLoadType[] DeadLoad
        {
            get
            {
                return this.deadLoadField;
            }
            set
            {
                this.deadLoadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Baggage")]
        public BaggageLoadType[] Baggage
        {
            get
            {
                return this.baggageField;
            }
            set
            {
                this.baggageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fuel")]
        public FuelDataType[] Fuel
        {
            get
            {
                return this.fuelField;
            }
            set
            {
                this.fuelField = value;
            }
        }
    }
}