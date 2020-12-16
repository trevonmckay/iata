using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class DiversionSequenceUnitTests
    {
        [Fact]
        public void Divert_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/diversion sequence/175.divert.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("175", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GCIVX", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("JFK", item));

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
        public void Divert_Airborne_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/diversion sequence/175.divert.airborne"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("175", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GCIVX", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("JFK", item));

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
        public void Divert_Continuation_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/diversion sequence/175.divert.continuation"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("175", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("BOS", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GCIVX", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("JFK", item));

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
        public void Divert_Diffrent_Destination_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/diversion sequence/175.divert.different_destination"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("175", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 4), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GCIVX", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("JFK", item),
                item => Assert.Equal("BOS", item)
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
    }
}
