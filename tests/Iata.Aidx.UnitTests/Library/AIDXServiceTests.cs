using FluentAssertions;
using IATA.AIDX.Messages;
using System;
using System.Linq;
using Xunit;

namespace IATA.AIDX.UnitTests.Library
{
    public class AIDXServiceTests
    {
        private readonly IAIDXService _service;

        public AIDXServiceTests()
        {
            _service = new AIDXService();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void When_EmptyOrNull_XmlMessagePath_ProcessAIDXMessageTest_Should_Throw_ArgumentNullException(string xmlMessagePath)
        {
            // Arrange 
            // Act
            Action action = () => this._service.ProcessAIDXMessage<IATA_AIDX_FlightLegNotifRQ>(xmlMessagePath);
            // Assert
            action.Should().Throw<ArgumentNullException>();
        }


        [Theory]
        [InlineData("DATA/de-ice message/458.dice")]
        [InlineData("DATA/codeshare message/953.codeshare")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.1")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.airborne")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.continue_leg.1")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.continue_leg.2")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.departed")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.return_leg")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.return_leg.arrived")]
        [InlineData("DATA/airborne return sequence/766.airborne_return.return_leg.touchdown")]
        [InlineData("DATA/apron message/969.apron")]
        [InlineData("DATA/cancel flight sequence/954.1")]
        [InlineData("DATA/cancel flight sequence/954.cancel")]
        [InlineData("DATA/cancel reinstate sequence/217.cancel_reinstate.1")]
        [InlineData("DATA/cancel reinstate sequence/217.cancel_reinstate.cancel")]
        [InlineData("DATA/cancel reinstate sequence/217.cancel_reinstate.reinstate")]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_XmlMessagePath_ProcessAIDXMessageTest_Should_Throw_Exception_XSD_Validation(string xmlMessagePath)
        {
            // Arrange 
            // Act
            Action action = () => this._service.ProcessAIDXMessage<IATA_AIDX_FlightLegNotifRQ>(xmlMessagePath);
            // Assert
            action.Should().NotThrow<ArgumentNullException>();
        }



        [Theory]
        [InlineData(typeof(IATA_AIDX_FlightLegNotifRQ), "DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_XmlMessagePath_ProcessAIDXMessageTest_Should_Return_IATA_AIDX_FlightLegNotifRQ(Type messageType, string xmlMessagePath)
        {
            // Arrange 
            // Act
            var message = this._service.ProcessAIDXMessage<IATA_AIDX_FlightLegNotifRQ>(xmlMessagePath);
            // Assert
            message.Should().BeOfType(messageType);
        }


        [Theory]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Have_FlightLegData(string xmlPath)
        {
            IATA_AIDX_FlightLegNotifRQ message = GetAIDXMessage(xmlPath);

            // Assert
            message.FlightLeg.FirstOrDefault().LegData.Should().NotBeNull();
            message.FlightLeg.FirstOrDefault().LegData.AircraftInfo.Should().NotBeNull();
            message.FlightLeg.FirstOrDefault().LegData.CabinClass.Count().Should().Be(4);

        }

        [Theory]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Have_FlightLegIdentifier(string xmlPath)
        {
            IATA_AIDX_FlightLegNotifRQ message = GetAIDXMessage(xmlPath);

            // Assert
            message.FlightLeg.FirstOrDefault().Item.Should().NotBeNull();
        }

        [Theory]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Have_FlightLeg_LegData_CodeShareInfo(string xmlPath)
        {
            IATA_AIDX_FlightLegNotifRQ message = GetAIDXMessage(xmlPath);

            // Assert

            message.FlightLeg.FirstOrDefault().LegData.CodeShareInfo.Count().Should().BeGreaterThan(0);
            message.FlightLeg.FirstOrDefault().LegData.CodeShareInfo.Count().Should().Be(3);
        }

        [Theory]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Have_FlightLeg_LegData_AirportResources(string xmlPath)
        {
            IATA_AIDX_FlightLegNotifRQ message = GetAIDXMessage(xmlPath);

            // Assert
            message.FlightLeg.FirstOrDefault().LegData.AirportResources.Count().Should().Be(1);
            message.FlightLeg.FirstOrDefault().LegData.AirportResources.FirstOrDefault().Resource.Count().Should().Be(2);

        }

        [Theory]
        [InlineData("DATA/IATA_AIDX_FlightLegNotifRQ.xml")]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Have_FlightLeg_LegData_OperationTime(string xmlPath)
        {
            IATA_AIDX_FlightLegNotifRQ message = GetAIDXMessage(xmlPath);

            // Assert
            message.FlightLeg.FirstOrDefault().LegData.OperationTime.Count().Should().BeGreaterThan(0);
            message.FlightLeg.FirstOrDefault().LegData.OperationTime.Count().Should().Be(12);
        }




        private IATA_AIDX_FlightLegNotifRQ GetAIDXMessage(string xmlPath)
        {
            // Arrange   
            // Act           
            var message = this._service.ProcessAIDXMessage<IATA_AIDX_FlightLegNotifRQ>(xmlPath);
            return message;
        }
    }
}
