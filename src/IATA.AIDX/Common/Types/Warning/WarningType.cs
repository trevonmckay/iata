namespace IATA.AIDX.Common.Types.Warning
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.iata.org/IATA/2007/00")]
    public partial class WarningType : FreeTextType
    {

        private string typeField;

        private string shortTextField;

        private string codeField;

        private string docURLField;

        private string statusField;

        private string tagField;

        private string recordIDField;

        private string ownerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ShortText
        {
            get
            {
                return shortTextField;
            }
            set
            {
                shortTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Code
        {
            get
            {
                return codeField;
            }
            set
            {
                codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
        public string DocURL
        {
            get
            {
                return docURLField;
            }
            set
            {
                docURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Tag
        {
            get
            {
                return tagField;
            }
            set
            {
                tagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RecordID
        {
            get
            {
                return recordIDField;
            }
            set
            {
                recordIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Owner
        {
            get
            {
                return ownerField;
            }
            set
            {
                ownerField = value;
            }
        }
    }
}