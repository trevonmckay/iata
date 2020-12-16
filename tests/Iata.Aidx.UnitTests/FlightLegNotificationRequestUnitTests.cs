using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class FlightLegNotificationRequestUnitTests
    {
        [Fact]
        public void Flight_Leg_Notification_Test()
        {
            // Arrange
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act        
            using (var streamReader = new StreamReader("DATA/IATA_AIDX_FlightLegNotifRQ.xml"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("DL", request.Originator.CompanyShortName);
            Assert.Equal("A", request.Originator.TravelSector);
            Assert.Equal("DL", request.Originator.Code);

            Assert.Equal("DL", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("0751", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal(new DateTime(2020, 11, 23), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal("PDX", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("ATL", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);
            Assert.Equal("PS", request.FlightLeg.LegData.ServiceType);
            Assert.Collection(request.FlightLeg.LegData.CodeShareInfo,
                item => Assert.Equal("VS", item.Airline),
                item => Assert.Equal("AF", item.Airline),
                item => Assert.Equal("KL", item.Airline));
            Assert.Equal("737", request.FlightLeg.LegData.AircraftInfo.AircraftType);
        }        
    }
}
