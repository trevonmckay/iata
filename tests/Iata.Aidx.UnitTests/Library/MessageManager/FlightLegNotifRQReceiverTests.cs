using FluentAssertions;
using IATA.AIDX.AIDXMessageManager.AIDXMessageReceiver;
using IATA.AIDX.Messages;
using Xunit;

namespace Iata.Aidx.UnitTests.Library.MessageManager
{

    public class FlightLegNotifRQReceiverTests
    {
        [Fact]
        public void When_FlightLegRQReceiver_ReceiveAIDXMessage_Should_Be_Type_IATA_AIDX_FlightLegNotifRQ()
        {
            // Arrange
            var receiver = new FlightLegNotifRQReceiver();
            // Act
            var message = receiver.ReceiveAIDXMessage();
            // Assert
            message.Should().BeOfType<IATA_AIDX_FlightLegNotifRQ>();

        }
    }
}