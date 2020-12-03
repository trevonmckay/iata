using IATA.AIDX.Qualifiers;

namespace IATA.AIDX
{
    public sealed class OperationTime
    {
        public string CodeContext { get; set; }

        public OperationalTimeQualifier OperationQualifier { get; set; }

        public OperationalTimeQualifierType TimeType { get; set; }
    }
}
