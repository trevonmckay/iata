using FluentAssertions;
using IATA.AIDX;
using IATA.AIDX.FlightLiveReader;
using System;
using System.IO;
using System.Xml;
using Xunit;

namespace Iata.Aidx.UnitTests.Library
{
    /**
     *A variety of AIDX messages are generated as a result of changes in
      difference source systems:flight updates, apron messages,
      de-ice messages, codeshare messages, and flight delete messages.  Flight
      delete messages are intended to remove a flight from the BA schedule. 
     */
    /**
     *  Operations
     * 
     * GetFlightUpdates
     * GetAPRONMessages
     * ParseDeiceMessages
     * GetCodeShareMessages
     * GetFlightDeleteMessages
     * 
     * All this functions return the same data
     * 
     */

    public class FlightLiveTests
    {
        private readonly IFlightLive _service;
        public FlightLiveTests()
        {
            _service = new FlightLive();
        }


        [Fact]
        public void When_DeiceMessage_Should_NotBe_Null()
        {
            // Arrange
            var xml = new XmlDocument();
            // Act
            FlightLegNotificationRequest deiceMessage = this._service.ParseDeiceMessage(xml);
            // Assert
            deiceMessage.Should().NotBeNull();
        }


        [Fact]
        public void When_DeiceMessage_Receive_Stream_Should_NotBe_Null()
        {
            // Arrange
            var streamReader = new StreamReader("DATA/de-ice message/458.dice");
            // Act
            FlightLegNotificationRequest deiceMessage = this._service.ParseDeiceMessage(streamReader);
            // Assert
            deiceMessage.Should().NotBeNull();
        }



        [Fact]
        public void When_DeiceMessage_Should_ThrowException_ArgumentNullException()
        {
            // Arrange
            // Act
            Action action = () => this._service.ParseDeiceMessage(xml: null);
            // Assert
            action.Should().Throw<ArgumentNullException>();
        }


        [Fact]
        public void When_DeiceMessage_Should_RETURN_FLIGHTLEG()
        {
            // Arrange
            var streamReader = new StreamReader("DATA/de-ice message/458.dice");
            // Act
            FlightLegNotificationRequest deiceMessage = this._service.ParseDeiceMessage(streamReader);
            // Assert
            deiceMessage.FlightLeg.Should().NotBeNull();
            deiceMessage.FlightLeg.LegIdentifier.Should().NotBeNull();

        }



        [Theory]
        [InlineData("DATA/de-ice message/458.dice")]
        [InlineData("DATA/cancel flight sequence/954.1")]
        [InlineData("DATA/cancel flight sequence/954.cancel")]
        [InlineData("DATA/flight delete message/6589.delete")]
        public void When_FlightXmlMessage_Should_RETURN_FLIGHTLEG(string xmlfile)
        {
            // Arrange
            var streamReader = new StreamReader(xmlfile);
            // Act
            FlightLegNotificationRequest deiceMessage = this._service.ParseDeiceMessage(streamReader);
            // Assert
            deiceMessage.FlightLeg.Should().NotBeNull();
            deiceMessage.FlightLeg.LegIdentifier.Should().NotBeNull();

        }
    }

}
