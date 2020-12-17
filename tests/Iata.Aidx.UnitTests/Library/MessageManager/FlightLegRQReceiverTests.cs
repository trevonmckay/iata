using FluentAssertions;
using IATA.AIDX.AIDXMessageManager.AIDXMessageReceiver;
using IATA.AIDX.Messages;
using Xunit;

namespace Iata.Aidx.UnitTests.Library.MessageManager
{
    public class FlightLegRQReceiverTests
    {
        [Fact]
        public void When_FlightLegRQReceiver_ReceiveAIDXMessage_Should_Be_Type_IATA_AIDX_FlightLegRQ()
        {
            // Arrange
            var receiver = new FlightLegRQReceiver();
            // Act
            var message = receiver.ReceiveAIDXMessage();
            // Assert
            message.Should().BeOfType<IATA_AIDX_FlightLegRQ>();

        }
    }
}
