using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class FlightDeleteUnitTests
    {
        [Fact]
        public void Flight_Delete_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/flight delete message/6589.delete"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("6589", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LGA", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("ORD", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 7, 17), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("Delete", request.FlightLeg.SpecialAction);
        }
    }
}
