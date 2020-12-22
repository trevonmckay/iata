namespace IATA.AIDX.Common.FlightLegNotifRQ
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IATA_AIDX_FlightLegNotifRQOriginator
    {

        private string companyShortNameField;

        private string travelSectorField;

        private string codeField;

        private string codeContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyShortName
        {
            get
            {
                return this.companyShortNameField;
            }
            set
            {
                this.companyShortNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeContext
        {
            get
            {
                return this.codeContextField;
            }
            set
            {
                this.codeContextField = value;
            }
        }
    }
}