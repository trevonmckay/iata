namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class FlightLegTypeLegDataCabinClass
    {

        private FlightLegTypeLegDataCabinClassInflightService[] inflightServiceField;

        private FlightLegTypeLegDataCabinClassInflightMealService[] inflightMealServiceField;

        private FlightLegTypeLegDataCabinClassPaxCount[] paxCountField;

        private FlightLegTypeLegDataCabinClassSeatCapacity seatCapacityField;

        private string classField;

        private string repeatIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InflightService", IsNullable = true)]
        public FlightLegTypeLegDataCabinClassInflightService[] InflightService
        {
            get
            {
                return this.inflightServiceField;
            }
            set
            {
                this.inflightServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InflightMealService", IsNullable = true)]
        public FlightLegTypeLegDataCabinClassInflightMealService[] InflightMealService
        {
            get
            {
                return this.inflightMealServiceField;
            }
            set
            {
                this.inflightMealServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaxCount", IsNullable = true)]
        public FlightLegTypeLegDataCabinClassPaxCount[] PaxCount
        {
            get
            {
                return this.paxCountField;
            }
            set
            {
                this.paxCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FlightLegTypeLegDataCabinClassSeatCapacity SeatCapacity
        {
            get
            {
                return this.seatCapacityField;
            }
            set
            {
                this.seatCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
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
    }
}