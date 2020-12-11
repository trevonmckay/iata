using IATA.AIDX;
using IATA.AIDX.CustomXmlReader;
using System;
using System.IO;
using System.Xml.Serialization;
using Xunit;

namespace Iata.Aidx.UnitTests
{
    public class DeIceUnitTests
    {
        [Fact]
        public void CancelFlightReinstate_Test()
        {
            // Arrange         
            var xmlSerializer = new XmlSerializer(typeof(FlightLegNotificationRequest));
            FlightLegNotificationRequest request;

            // Act
            using (var streamReader = new StreamReader("DATA/de-ice message/458.dice"))
            {
                request = (FlightLegNotificationRequest)xmlSerializer.Deserialize(new CustomXmlReader(streamReader));
            }

            // Assert
            Assert.Equal("BA", request.FlightLeg.LegIdentifier.Airline);
            Assert.Equal("458", request.FlightLeg.LegIdentifier.FlightNumber);
            Assert.Equal("LHR", request.FlightLeg.LegIdentifier.DepartureAirport);
            Assert.Equal("MAD", request.FlightLeg.LegIdentifier.ArrivalAirport);
            Assert.Equal(new DateTime(2015, 6, 5), request.FlightLeg.LegIdentifier.OriginDate);
            Assert.Equal(1, request.FlightLeg.LegIdentifier.RepeatNumber);

            Assert.Collection(request.FlightLeg.LegData.OperationTime,
                item => Assert.Equal("DIC", item.OperationQualifierObj.Code),
                item => Assert.Equal("DIE", item.OperationQualifierObj.Code),
                item => Assert.Equal("DIC", item.OperationQualifierObj.Code),
                item => Assert.Equal("DIE", item.OperationQualifierObj.Code)
                );
        }
    }
}
