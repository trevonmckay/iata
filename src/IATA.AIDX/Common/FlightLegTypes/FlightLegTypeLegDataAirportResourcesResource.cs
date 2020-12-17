using IATA.AIDX.Common.Types;

namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataAirportResourcesResource
    {

        private string airportZoneField;

        private FlightLegTypeLegDataAirportResourcesResourceAircraftParkingPosition aircraftParkingPositionField;

        private FlightLegTypeLegDataAirportResourcesResourcePassengerGate[] passengerGateField;

        private FlightLegTypeLegDataAirportResourcesResourceRemoteOperationalGate[] remoteOperationalGateField;

        private string runwayField;

        private string aircraftTerminalField;

        private FlightLegTypeLegDataAirportResourcesResourcePublicTerminal[] publicTerminalField;

        private System.Nullable<bool> crewBusIndField;

        private bool crewBusIndFieldSpecified;

        private System.Nullable<bool> paxBusIndField;

        private bool paxBusIndFieldSpecified;

        private FlightLegTypeLegDataAirportResourcesResourceBaggageClaimUnit[] baggageClaimUnitField;

        private FlightLegTypeLegDataAirportResourcesResourceBaggageMakeupBelt[] baggageMakeupBeltField;

        private FlightLegTypeLegDataAirportResourcesResourceCheckInInfo[] checkInInfoField;

        private System.Nullable<bool> preClearedGateIndField;

        private bool preClearedGateIndFieldSpecified;

        private FlightLegTypeLegDataAirportResourcesResourceDeIceLocation deIceLocationField;

        private DepartureArrivalType departureOrArrivalField;

        private string chargeTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AirportZone
        {
            get
            {
                return this.airportZoneField;
            }
            set
            {
                this.airportZoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceAircraftParkingPosition AircraftParkingPosition
        {
            get
            {
                return this.aircraftParkingPositionField;
            }
            set
            {
                this.aircraftParkingPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PassengerGate", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourcePassengerGate[] PassengerGate
        {
            get
            {
                return this.passengerGateField;
            }
            set
            {
                this.passengerGateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RemoteOperationalGate", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceRemoteOperationalGate[] RemoteOperationalGate
        {
            get
            {
                return this.remoteOperationalGateField;
            }
            set
            {
                this.remoteOperationalGateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Runway
        {
            get
            {
                return this.runwayField;
            }
            set
            {
                this.runwayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AircraftTerminal
        {
            get
            {
                return this.aircraftTerminalField;
            }
            set
            {
                this.aircraftTerminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PublicTerminal", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourcePublicTerminal[] PublicTerminal
        {
            get
            {
                return this.publicTerminalField;
            }
            set
            {
                this.publicTerminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> CrewBusInd
        {
            get
            {
                return this.crewBusIndField;
            }
            set
            {
                this.crewBusIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrewBusIndSpecified
        {
            get
            {
                return this.crewBusIndFieldSpecified;
            }
            set
            {
                this.crewBusIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> PaxBusInd
        {
            get
            {
                return this.paxBusIndField;
            }
            set
            {
                this.paxBusIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaxBusIndSpecified
        {
            get
            {
                return this.paxBusIndFieldSpecified;
            }
            set
            {
                this.paxBusIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaggageClaimUnit", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceBaggageClaimUnit[] BaggageClaimUnit
        {
            get
            {
                return this.baggageClaimUnitField;
            }
            set
            {
                this.baggageClaimUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaggageMakeupBelt", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceBaggageMakeupBelt[] BaggageMakeupBelt
        {
            get
            {
                return this.baggageMakeupBeltField;
            }
            set
            {
                this.baggageMakeupBeltField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CheckInInfo", IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceCheckInInfo[] CheckInInfo
        {
            get
            {
                return this.checkInInfoField;
            }
            set
            {
                this.checkInInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> PreClearedGateInd
        {
            get
            {
                return this.preClearedGateIndField;
            }
            set
            {
                this.preClearedGateIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreClearedGateIndSpecified
        {
            get
            {
                return this.preClearedGateIndFieldSpecified;
            }
            set
            {
                this.preClearedGateIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FlightLegTypeLegDataAirportResourcesResourceDeIceLocation DeIceLocation
        {
            get
            {
                return this.deIceLocationField;
            }
            set
            {
                this.deIceLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DepartureArrivalType DepartureOrArrival
        {
            get
            {
                return this.departureOrArrivalField;
            }
            set
            {
                this.departureOrArrivalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeType
        {
            get
            {
                return this.chargeTypeField;
            }
            set
            {
                this.chargeTypeField = value;
            }
        }
    }
}