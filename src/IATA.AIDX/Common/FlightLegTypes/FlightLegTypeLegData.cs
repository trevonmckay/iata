namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegData
    {

        private FlightLegTypeLegDataOperationalStatus[] operationalStatusField;

        private FlightLegTypeLegDataPublicStatus[] publicStatusField;

        private string operatingAllianceField;

        private string serviceTypeField;

        private FlightLegTypeLegDataTechnicalStopInd[] technicalStopIndField;

        private System.Nullable<bool> depSecurityCheckIndField;

        private bool depSecurityCheckIndFieldSpecified;

        private System.Nullable<bool> arrSecurityCheckIndField;

        private bool arrSecurityCheckIndFieldSpecified;

        private string estFlightDurationField;

        private FlightLegTypeLegDataOwnerAirline ownerAirlineField;

        private FlightLegTypeLegDataPlannedArrivalAptHistory[] plannedArrivalAptHistoryField;

        private FlightLegTypeLegDataSpecialEmphasis[] specialEmphasisField;

        private FlightLegTypeLegDataIrregularityDelay[] irregularityDelayField;

        private FlightLegTypeLegDataCabinClass[] cabinClassField;

        private FlightLegTypeLegDataSpecialCargo[] specialCargoField;

        private FlightLegTypeLegDataCodeShareInfo[] codeShareInfoField;

        private FlightLegTypeLegDataAssociatedFlightLegAircraft[] associatedFlightLegAircraftField;

        private FlightLegTypeLegDataAssociatedFlightLegSchedule[] associatedFlightLegScheduleField;

        private FlightLegTypeLegDataRemarkTextCode[] remarkTextCodeField;

        private FlightLegTypeLegDataRemarkFreeText[] remarkFreeTextField;

        private FlightLegTypeLegDataAirportResources[] airportResourcesField;

        private FlightLegTypeLegDataOperationTime[] operationTimeField;

        private FlightLegTypeLegDataAircraftInfo aircraftInfoField;

        private string clearanceAgreementField;

        private FlightLegTypeLegDataPublicFlightDisplay publicFlightDisplayField;

        private FlightLegTypeLegDataFlightCrewAirline flightCrewAirlineField;

        private FlightLegTypeLegDataCabinCrewAirline cabinCrewAirlineField;

        private FlightLegTypeLegDataOperationDuration[] operationDurationField;

        private string flightClassificationField;

        private FlightLegTypeLegDataInternationalStatus internationalStatusField;

        private bool internationalStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationalStatus", IsNullable = true)]
        public FlightLegTypeLegDataOperationalStatus[] OperationalStatus
        {
            get
            {
                return this.operationalStatusField;
            }
            set
            {
                this.operationalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PublicStatus", IsNullable = true)]
        public FlightLegTypeLegDataPublicStatus[] PublicStatus
        {
            get
            {
                return this.publicStatusField;
            }
            set
            {
                this.publicStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OperatingAlliance
        {
            get
            {
                return this.operatingAllianceField;
            }
            set
            {
                this.operatingAllianceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalStopInd", IsNullable = true)]
        public FlightLegTypeLegDataTechnicalStopInd[] TechnicalStopInd
        {
            get
            {
                return this.technicalStopIndField;
            }
            set
            {
                this.technicalStopIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> DepSecurityCheckInd
        {
            get
            {
                return this.depSecurityCheckIndField;
            }
            set
            {
                this.depSecurityCheckIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepSecurityCheckIndSpecified
        {
            get
            {
                return this.depSecurityCheckIndFieldSpecified;
            }
            set
            {
                this.depSecurityCheckIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> ArrSecurityCheckInd
        {
            get
            {
                return this.arrSecurityCheckIndField;
            }
            set
            {
                this.arrSecurityCheckIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArrSecurityCheckIndSpecified
        {
            get
            {
                return this.arrSecurityCheckIndFieldSpecified;
            }
            set
            {
                this.arrSecurityCheckIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration", IsNullable = true)]
        public string EstFlightDuration
        {
            get
            {
                return this.estFlightDurationField;
            }
            set
            {
                this.estFlightDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FlightLegTypeLegDataOwnerAirline OwnerAirline
        {
            get
            {
                return this.ownerAirlineField;
            }
            set
            {
                this.ownerAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlannedArrivalAptHistory", IsNullable = true)]
        public FlightLegTypeLegDataPlannedArrivalAptHistory[] PlannedArrivalAptHistory
        {
            get
            {
                return this.plannedArrivalAptHistoryField;
            }
            set
            {
                this.plannedArrivalAptHistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialEmphasis", IsNullable = true)]
        public FlightLegTypeLegDataSpecialEmphasis[] SpecialEmphasis
        {
            get
            {
                return this.specialEmphasisField;
            }
            set
            {
                this.specialEmphasisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IrregularityDelay", IsNullable = true)]
        public FlightLegTypeLegDataIrregularityDelay[] IrregularityDelay
        {
            get
            {
                return this.irregularityDelayField;
            }
            set
            {
                this.irregularityDelayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CabinClass")]
        public FlightLegTypeLegDataCabinClass[] CabinClass
        {
            get
            {
                return this.cabinClassField;
            }
            set
            {
                this.cabinClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialCargo", IsNullable = true)]
        public FlightLegTypeLegDataSpecialCargo[] SpecialCargo
        {
            get
            {
                return this.specialCargoField;
            }
            set
            {
                this.specialCargoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CodeShareInfo", IsNullable = true)]
        public FlightLegTypeLegDataCodeShareInfo[] CodeShareInfo
        {
            get
            {
                return this.codeShareInfoField;
            }
            set
            {
                this.codeShareInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedFlightLegAircraft", IsNullable = true)]
        public FlightLegTypeLegDataAssociatedFlightLegAircraft[] AssociatedFlightLegAircraft
        {
            get
            {
                return this.associatedFlightLegAircraftField;
            }
            set
            {
                this.associatedFlightLegAircraftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedFlightLegSchedule", IsNullable = true)]
        public FlightLegTypeLegDataAssociatedFlightLegSchedule[] AssociatedFlightLegSchedule
        {
            get
            {
                return this.associatedFlightLegScheduleField;
            }
            set
            {
                this.associatedFlightLegScheduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RemarkTextCode", IsNullable = true)]
        public FlightLegTypeLegDataRemarkTextCode[] RemarkTextCode
        {
            get
            {
                return this.remarkTextCodeField;
            }
            set
            {
                this.remarkTextCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RemarkFreeText", IsNullable = true)]
        public FlightLegTypeLegDataRemarkFreeText[] RemarkFreeText
        {
            get
            {
                return this.remarkFreeTextField;
            }
            set
            {
                this.remarkFreeTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirportResources")]
        public FlightLegTypeLegDataAirportResources[] AirportResources
        {
            get
            {
                return this.airportResourcesField;
            }
            set
            {
                this.airportResourcesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationTime", IsNullable = true)]
        public FlightLegTypeLegDataOperationTime[] OperationTime
        {
            get
            {
                return this.operationTimeField;
            }
            set
            {
                this.operationTimeField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeLegDataAircraftInfo AircraftInfo
        {
            get
            {
                return this.aircraftInfoField;
            }
            set
            {
                this.aircraftInfoField = value;
            }
        }

        /// <remarks/>
        public string ClearanceAgreement
        {
            get
            {
                return this.clearanceAgreementField;
            }
            set
            {
                this.clearanceAgreementField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeLegDataPublicFlightDisplay PublicFlightDisplay
        {
            get
            {
                return this.publicFlightDisplayField;
            }
            set
            {
                this.publicFlightDisplayField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeLegDataFlightCrewAirline FlightCrewAirline
        {
            get
            {
                return this.flightCrewAirlineField;
            }
            set
            {
                this.flightCrewAirlineField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeLegDataCabinCrewAirline CabinCrewAirline
        {
            get
            {
                return this.cabinCrewAirlineField;
            }
            set
            {
                this.cabinCrewAirlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationDuration")]
        public FlightLegTypeLegDataOperationDuration[] OperationDuration
        {
            get
            {
                return this.operationDurationField;
            }
            set
            {
                this.operationDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightClassification
        {
            get
            {
                return this.flightClassificationField;
            }
            set
            {
                this.flightClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FlightLegTypeLegDataInternationalStatus InternationalStatus
        {
            get
            {
                return this.internationalStatusField;
            }
            set
            {
                this.internationalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InternationalStatusSpecified
        {
            get
            {
                return this.internationalStatusFieldSpecified;
            }
            set
            {
                this.internationalStatusFieldSpecified = value;
            }
        }
    }
}