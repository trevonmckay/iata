using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class PreDepartureDiversionSequenceUnitTests
    {
        [Fact]
        public void Pre_Dep_Divert_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/pre departure diversion sequence/107.pre_dep_divert.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("106", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("DXB", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("LHR", item));

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("SRT", item.OperationQualifierObj.Code),
                item => Assert.Equal("OFB", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TKO", item.OperationQualifierObj.Code),
                item => Assert.Equal("TDN", item.OperationQualifierObj.Code),
                item => Assert.Equal("ONB", item.OperationQualifierObj.Code)
                );
        }

        [Fact]
        public void Pre_Dep_Divert_Continuation_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/pre departure diversion sequence/107.pre_dep_divert.continuation"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("107", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("IST", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("DXB", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GBNLP", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("DXB", item));

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
        public void Pre_Dep_Divert_Different_Destination_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/pre departure diversion sequence/107.pre_dep_divert.different_destination"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("107", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("DXB", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GBNLP", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("DXB", item),
                item => Assert.Equal("IST", item));

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
        public void Pre_Dep_Divert_No_Continue_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/pre departure diversion sequence/115.pre_dep_divert.no_continue.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("115", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GBYGD", request.FlightLeg.LegData.AircraftInfo.Registration);

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
        public void Pre_Dep_Divert_No_Continue_Different_Destination_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/pre departure diversion sequence/115.pre_dep_divert.no_continue.different_destination"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("115", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("JFK", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            
            Assert.Equal("744", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GBYGD", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("JFK", item),
                item => Assert.Equal("BOS", item));

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
