using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class NormalFlightSequenceUnitTests
    {
        [Fact]
        public void Normal_Flight_Sequence_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/normal flight sequence/normal.1484.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1484", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("GLA", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("321", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUXH", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("GLA", item));

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
        public void Normal_Flight_Sequence_Airborne_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/normal flight sequence/normal.1484.airborne"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1484", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("GLA", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("321", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUXH", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("GLA", item));

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
        public void Normal_Flight_Sequence_Arrival_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/normal flight sequence/normal.1484.arrival"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1484", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("GLA", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("321", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUXH", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("GLA", item));

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
        public void Normal_Flight_Sequence_Departed_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/normal flight sequence/normal.1484.departed"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1484", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("GLA", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("321", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUXH", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("GLA", item));

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
        public void Normal_Flight_Sequence_Touchdown_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/normal flight sequence/normal.1484.touchdown"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1484", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("GLA", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("321", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUXH", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("GLA", item));

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
