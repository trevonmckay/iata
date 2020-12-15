using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using IATA.AIDX.FlightStatusQualifier;
using IATA.AIDX.Qualifiers;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class AirborneReturnSequenceUnitTests
    {
        [Fact]
        public void Airborne_Return_Sequence_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("Actual", request.FlightLeg.LegData.AirportResources.Usage);
            Assert.Equal("319", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUPY", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.OperationalStatus,
                item => Assert.Equal(FlightOperationalStatus.Scheduled.Code, item.Code),
                item => Assert.Equal(FlightOperationalStatus.Scheduled.Code, item.Code)
            );

            Assert.Collection(request.FlightLeg.LegData.AssociatedFlightLegAircraft,
                item => Assert.Equal("BA", item.Airline),
                item => Assert.Equal("BA", item.Airline)
                );

            Assert.Collection(request.FlightLeg.LegData.AssociatedFlightLegAircraft,
                item => Assert.Equal("373", item.FlightNumber),
                item => Assert.Equal("767", item.FlightNumber)
                );

            Assert.Collection(request.FlightLeg.LegData.AssociatedFlightLegAircraft,
                item => Assert.Equal("TLS", item.DepartureAirport),
                item => Assert.Equal("LHR", item.ArrivalAirport)
                );

            Assert.Collection(request.FlightLeg.LegData.AssociatedFlightLegAircraft,
                item => Assert.Equal(new DateTime(2015, 6, 4), item.OriginDate),
                item => Assert.Equal(new DateTime(2015, 6, 4), item.OriginDate)
                );

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("OSL", item));

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );

            // TODO: Figure out the AirportResources.Resource.  NULL values are coming through
            //Assert.Collection(request.FlightLeg.LegData.AirportResources.Resource,
            //    item => Assert.Equal("Departure", item.DepartureOrArrival),
            //    item => Assert.Equal("Arrival", item.DepartureOrArrival)
            //    );                 
        }

        [Fact]
        public void Airborne_Return_Sequence_Second_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.airborne"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationalStatus,
                item => Assert.Equal(FlightOperationalStatus.OffBlock.Code, item.Code),
                item => Assert.Equal(FlightOperationalStatus.OperationalFlight.Code, item.Code)
            );
           
            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Continue_Leg_Test_One()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.continue_leg.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Continue_Leg_Test_Two()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.continue_leg.2"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Continue_Leg_Departed_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.continue_leg.departed"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Departed_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.departed"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Return_Leg_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.return_leg"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Leg_Arrived_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.return_leg.arrived"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Airborne_Return_Leg_Touchdown_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/airborne return sequence/766.airborne_return.return_leg.touchdown"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("766", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("OSL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }
    }
}
