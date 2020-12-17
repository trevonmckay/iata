using System;

namespace IATA.AIDX.Messages
{


    public interface IAIDX_FlightLegMessage
    {
        string CorrelationID { get; set; }
        bool AsynchronousAllowedInd { get; set; }
        bool AsynchronousAllowedIndSpecified { get; set; }
        string EchoToken { get; set; }
        string SequenceNmbr { get; set; }
        bool RetransmissionIndicator { get; set; }
        bool RetransmissionIndicatorSpecified { get; set; }
        DateTime TimeStamp { get; set; }
        bool TimeStampSpecified { get; set; }
        string TransactionIdentifier { get; set; }
        bool TransactionStatusCodeSpecified { get; set; }
        decimal Version { get; set; }

    }
}