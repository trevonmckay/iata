------------------------------------------------------------
      README FOR BA AIDX VER 15.1 INSTANCE EXAMPLES
------------------------------------------------------------

%%%%%%% N.B. THESE EXAMPLES ARE DERIVED FROM FLIGHT  %%%%%%%
%%%%%%% SEQUENCES CREATED ON TEST SYSTEMS AND DO NOT %%%%%%%
%%%%%%% REFLECT ACTUAL OCCURRENCES IN THE LIVE BA    %%%%%%%
%%%%%%% SCHEDULE                                     %%%%%%%

A variety of AIDX messages are generated as a result of changes in
difference source systems:flight updates, apron messages,
de-ice messages, codeshare messages, and flight delete messages.  Flight
delete messages are intended to remove a flight from the BA schedule.

The sequences included are to demonstrate normal flight patterns, and 
some disruption scenarios.

The flight messages contain a number of operational status repeats.  
The convention adopted allocates departure status to the first repeat,
arrival status to the second repeat, and any further repeat indicates
diversion. (There is a change request in motion to add an attribute that
specifies this allocation).

The BA extension reflects elements that mostly have change requests 
in motion.  The AirborneRepeatNumber helps distinguish between returns that
are ground and airborne (RepeatNumber in the identifier is the total) 
as different parts of the operation have different requirements in this 
regard.  The only really bespoke element is AirborneReturnNumber which is 
required by some legacy systems.

N.B. BA AIDX instance examples use the pattern recently approved by the AIDX
working group for mapping A-CDM status to OperationalStatus, using values from
codeset 9750.
