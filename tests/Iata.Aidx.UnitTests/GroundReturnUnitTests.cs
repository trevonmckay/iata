using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class GroundReturnUnitTests
    {
        [Fact]
        public void Ground_Return_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/ground return sequence/1394.1"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1394", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAN", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("320", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUYB", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("MAN", item));

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
        public void Ground_Return_Departed_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/ground return sequence/1394.departed"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1394", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAN", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("320", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUYB", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("MAN", item));

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
        public void Ground_Return__Return_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/ground return sequence/1394.ground_return"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1394", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAN", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("320", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUYB", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("MAN", item));

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
        public void Ground_Return_Second_Attempt_Departed_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/ground return sequence/1394.second_attempt_departed"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1394", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAN", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("320", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUYB", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("MAN", item));

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
        public void Ground_Return_Second_Attempt_Etd_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/ground return sequence/1394.second_attempt_etd"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("1394", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAN", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 3), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(2, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("BA", request.FlightLeg.LegData.OwnerAirline.Airline);
            Assert.Equal("J", request.FlightLeg.LegData.ServiceType);
            Assert.Equal("320", request.FlightLeg.LegData.AircraftInfo.AircraftType);
            Assert.Equal("GEUYB", request.FlightLeg.LegData.AircraftInfo.Registration);

            Assert.Collection(request.FlightLeg.LegData.PlannedArrivalAptHistory,
                item => Assert.Equal("MAN", item));

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
