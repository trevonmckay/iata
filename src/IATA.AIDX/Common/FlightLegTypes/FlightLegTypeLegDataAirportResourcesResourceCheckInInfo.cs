namespace IATA.AIDX.Common.FlightLegTypes
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FlightLegTypeLegDataAirportResourcesResourceCheckInInfo
    {

        private string firstPositionField;

        private string lastPositionField;

        private string qualifierField;

        private string locationField;

        private string classField;

        private string repeatIndexField;

        /// <remarks/>
        public string FirstPosition
        {
            get
            {
                return this.firstPositionField;
            }
            set
            {
                this.firstPositionField = value;
            }
        }

        /// <remarks/>
        public string LastPosition
        {
            get
            {
                return this.lastPositionField;
            }
            set
            {
                this.lastPositionField = value;
            }
        }

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
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
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