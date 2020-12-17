using IATA.AIDX.Qualifiers;
using System.Xml.Serialization;

namespace IATA.AIDX
{
    public sealed class OperationTime
    {
        public string CodeContext { get; set; }

        [XmlAttribute]
        public string OperationQualifier { get; set; }

        public OperationalTimeQualifier OperationQualifierObj { 
            get { 
                return OperationalTimeQualifier.Qualifiers.ContainsKey(OperationQualifier) ?
                    OperationalTimeQualifier.Qualifiers[OperationQualifier] :
                    null; 
            } 
        }

        public OperationalTimeQualifierType TimeType { get; set; }
    }
}
