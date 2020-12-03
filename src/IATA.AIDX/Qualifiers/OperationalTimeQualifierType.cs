namespace IATA.AIDX.Qualifiers
{
    /// <summary>
    /// The significance of the time provided, e.g. estimated, actual.
    /// </summary>
    public sealed class OperationalTimeQualifierType
    {
        public static OperationalTimeQualifierType Scheduled = new OperationalTimeQualifierType("SCT", "Scheduled", "2005");

        public static OperationalTimeQualifierType Planned = new OperationalTimeQualifierType("PLN", "Planned", "2005");

        public static OperationalTimeQualifierType Estimated = new OperationalTimeQualifierType("EST", "Estimated", "2005");

        public static OperationalTimeQualifierType Target = new OperationalTimeQualifierType("TAR", "Target", "2005");

        public static OperationalTimeQualifierType Calculated = new OperationalTimeQualifierType("CAL", "Calculated", "2005");

        public static OperationalTimeQualifierType Actual = new OperationalTimeQualifierType("ACT", "Actual", "2005");

        private OperationalTimeQualifierType(string value, string description, string padisCodesetReference)
        {
            Code = value;
            Description = description;
            PadisCodesetReference = padisCodesetReference;
        }

        private OperationalTimeQualifierType() { }

        public string Code { get; set; }

        public string Description { get; set; }

        public string PadisCodesetReference { get; set; }
    }
}
