namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeGeneralAviationLegIdentifier
    {

        private FlightLegTypeGeneralAviationLegIdentifierAirline airlineField;

        private FlightLegTypeGeneralAviationLegIdentifierGeneralAviationIdentifier generalAviationIdentifierField;

        private FlightLegTypeGeneralAviationLegIdentifierDepartureAirport departureAirportField;

        private System.DateTime plannedDepartureDateTimeField;

        private string flightNumberField;

        private string operationalSuffixField;

        private FlightLegTypeGeneralAviationLegIdentifierArrivalAirport arrivalAirportField;

        private FlightLegTypeGeneralAviationLegIdentifierRepeatNumber repeatNumberField;

        /// <remarks/>
        public FlightLegTypeGeneralAviationLegIdentifierAirline Airline
        {
            get
            {
                return this.airlineField;
            }
            set
            {
                this.airlineField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeGeneralAviationLegIdentifierGeneralAviationIdentifier GeneralAviationIdentifier
        {
            get
            {
                return this.generalAviationIdentifierField;
            }
            set
            {
                this.generalAviationIdentifierField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeGeneralAviationLegIdentifierDepartureAirport DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        public System.DateTime PlannedDepartureDateTime
        {
            get
            {
                return this.plannedDepartureDateTimeField;
            }
            set
            {
                this.plannedDepartureDateTimeField = value;
            }
        }

        /// <remarks/>
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        public string OperationalSuffix
        {
            get
            {
                return this.operationalSuffixField;
            }
            set
            {
                this.operationalSuffixField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeGeneralAviationLegIdentifierArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public FlightLegTypeGeneralAviationLegIdentifierRepeatNumber RepeatNumber
        {
            get
            {
                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }
    }
}