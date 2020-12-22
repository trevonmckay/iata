namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataPublicFlightDisplay
    {

        private FlightLegTypeLegDataPublicFlightDisplayAirlineType airlineTypeField;

        private string flightNumberField;

        /// <remarks/>
        public FlightLegTypeLegDataPublicFlightDisplayAirlineType AirlineType
        {
            get
            {
                return this.airlineTypeField;
            }
            set
            {
                this.airlineTypeField = value;
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
    }
}