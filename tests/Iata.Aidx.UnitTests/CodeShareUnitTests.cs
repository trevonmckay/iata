using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class CodeShareUnitTests
    {
        [Fact]
        public void CodeShareInfo_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/codeshare message/953.codeshare"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new FlightXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("953", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("MUC", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 14), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.CodeShareInfo,
                item => Assert.Equal("AB", item.Airline),
                item => Assert.Equal("CX", item.Airline),
                item => Assert.Equal("JL", item.Airline)
                );

            Assert.Collection(request.FlightLeg.LegData.CodeShareInfo,
                item => Assert.Equal("5043", item.FlightNumber),
                item => Assert.Equal("7162", item.FlightNumber),
                item => Assert.Equal("7712", item.FlightNumber)
                );

            Assert.Collection(request.FlightLeg.LegData.CodeShareInfo,
                item => Assert.Equal(new DateTime(2015, 6, 14), item.OriginationDate),
                item => Assert.Equal(new DateTime(2015, 6, 14), item.OriginationDate),
                item => Assert.Equal(new DateTime(2015, 6, 14), item.OriginationDate)
                );
        }
    }
}
