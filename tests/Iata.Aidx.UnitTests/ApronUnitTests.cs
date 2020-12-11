using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class ApronUnitTests
    {
        [Fact]
        public void Apron_Test()
        {
            // Arrange
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/apron message/969.apron"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("969", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("HAM", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Equal("Planned", request.FlightLeg.LegData.AirportResources.Usage);

            //Assert.Collection(request.FlightLeg.LegData.AirportResources.Resource,
            //    item => Assert.Equal("Departure", item.DepartureOrArrival),
            //    item => Assert.Equal("Arrival", item.DepartureOrArrival)
            //    );

        }
    }
}
