using System.Collections.Generic;

namespace IATA.AIDX.Qualifiers
{
    /// <summary>
    /// The activity to which the time relates, e.g. touchdown, on-blocks.
    /// </summary>
    public sealed class OperationalTimeQualifier
    {
        public static OperationalTimeQualifier StartupRequestTime = new OperationalTimeQualifier("SRT", "Start up Request Time. (Time the pilot requests start up clearance.)", "9750");
        public static OperationalTimeQualifier OffBlockTime = new OperationalTimeQualifier("OFB", "Off Block time – Departure", "9750");
        public static OperationalTimeQualifier TakeOffTime = new OperationalTimeQualifier("TKO", "Take Off Time", "9750");
        public static OperationalTimeQualifier OnBlockTime = new OperationalTimeQualifier("ONB", "On Block time - Arrival", "9750");
        public static OperationalTimeQualifier TouchdownTime = new OperationalTimeQualifier("TDN", "Touchdown time", "9750");
        public static OperationalTimeQualifier DeIceStartTime = new OperationalTimeQualifier("DIC", "De-ice start time", "9750");
        public static OperationalTimeQualifier DeIceStopTime = new OperationalTimeQualifier("DIE", "De-ice end time", "9750");

        public static OperationalTimeQualifier CheckInOpen = new OperationalTimeQualifier("CHK", "Check-in Open", "9750");
        public static OperationalTimeQualifier InRange = new OperationalTimeQualifier("THM", "In Range", "9750");
        public static OperationalTimeQualifier Approach = new OperationalTimeQualifier("TEN", "Approach", "9750");        
        public static OperationalTimeQualifier CommenceGroundHandlingTime = new OperationalTimeQualifier("CGT", "Commence of Ground Handling Time", "9750");
        public static OperationalTimeQualifier FirstBagUnloadedTime = new OperationalTimeQualifier("FBG", "First bag unloaded", "9750");
        public static OperationalTimeQualifier AirBridgeAttach = new OperationalTimeQualifier("ABA", "Air bridge attach", "9750");
        public static OperationalTimeQualifier LastBagUnloaded = new OperationalTimeQualifier("LBG", "Last bag unloaded", "9750");
        public static OperationalTimeQualifier CheckInClosed = new OperationalTimeQualifier("CHC", "Check-in Closed", "9750");
        public static OperationalTimeQualifier GateOpen = new OperationalTimeQualifier("GTO", "Gate Open", "9750");
        public static OperationalTimeQualifier StartBoardingTime = new OperationalTimeQualifier("BST", "Start Boarding Time", "9750");
        public static OperationalTimeQualifier FinalCallTime = new OperationalTimeQualifier("FCT", "Final Call Time: Time of final call in lounge before the aircraft gate is closed.", "9750");
        public static OperationalTimeQualifier FinalBoarding = new OperationalTimeQualifier("BEN", "Final Boarding", "9750");
        public static OperationalTimeQualifier GateClosed = new OperationalTimeQualifier("GCL", "Gate Closed", "9750");
        public static OperationalTimeQualifier FlightClosed = new OperationalTimeQualifier("FCL", "Flight Closed", "9750");
        public static OperationalTimeQualifier AirBridgeDetach = new OperationalTimeQualifier("ABD", "Air bridge detach", "9750");
        public static OperationalTimeQualifier ReadyTime = new OperationalTimeQualifier("RDT", "Ready Time. (The time the pilot informs the ATC of being ready for pushback.)", "9750");
        public static OperationalTimeQualifier StartupApprovalTime = new OperationalTimeQualifier("SAT", "Start up Approval Time. (Time that an aircraft receives its start up approval.)", "9750");

        public static Dictionary<string, OperationalTimeQualifier> Qualifiers = new Dictionary<string, OperationalTimeQualifier>
        {
            { AirBridgeAttach.Code, AirBridgeAttach },
            { AirBridgeDetach.Code, AirBridgeDetach },
            { Approach.Code, Approach },
            { CheckInClosed.Code, CheckInClosed },
            { CheckInOpen.Code, CheckInOpen },
            { CommenceGroundHandlingTime.Code, CommenceGroundHandlingTime },
            { DeIceStartTime.Code, DeIceStartTime },
            { DeIceStopTime.Code, DeIceStopTime },
            { FinalBoarding.Code, FinalBoarding },
            { FirstBagUnloadedTime.Code, FirstBagUnloadedTime },
            { FlightClosed.Code, FlightClosed },            
            { GateClosed.Code, GateClosed },
            { GateOpen.Code, GateOpen },
            { InRange.Code, InRange },
            { LastBagUnloaded.Code, LastBagUnloaded },
            { OffBlockTime.Code, OffBlockTime },
            { OnBlockTime.Code, OnBlockTime },
            { ReadyTime.Code, ReadyTime },
            { StartBoardingTime.Code, StartBoardingTime },            
            { StartupApprovalTime.Code, StartupApprovalTime },
            { StartupRequestTime.Code, StartupRequestTime },            
            { TakeOffTime.Code, TakeOffTime },            
            { TouchdownTime.Code, TouchdownTime }            
        };

        private OperationalTimeQualifier(string code, string description, string padisCodesetReference) 
        {
            Code = code;
            Description = description;
            PadisCodesetReference = padisCodesetReference;
        }

        private OperationalTimeQualifier()
        {

        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string PadisCodesetReference { get; set; }
    }
}
