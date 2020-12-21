using FluentAssertions;
using IATA.AIDX.AIDXMessageManager;
using IATA.AIDX.Messages;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using Xunit;

namespace Iata.Aidx.UnitTests.Library.MessageManager
{
    public class AIDXMessageManagerTests
    {
        private readonly IAIDXMessageManager _aidxMessageManager;
        private readonly IAIDXMessageValidator _aidxXMLValidator;

        public AIDXMessageManagerTests()
        {
            var obj = new AIDXMessageManager();
            this._aidxMessageManager = obj;
            this._aidxXMLValidator = obj;
        }


        [Fact]
        public void When_AIDXMessageManager_ValidateXMLMessage_Should_Throw_Exception()
        {
            // Arrange
            var doc = new XmlDocument();
            // Act
            Action action = () => this._aidxXMLValidator.ValidateAIDXXMLMessage(doc);
            // Assert
            action.Should().Throw<Exception>();
        }


        [Theory]
        [InlineData(typeof(XmlDocument), "<?xml version='1.0' encoding='UTF-8'?><t><word>bla bla</word></t>")]
        [InlineData(typeof(XmlDocument), "<?xml version='1.0' encoding='UTF-8'?><item><name>wrench</name></item>")]
        public void When_AIDXMessageManager_XMLNotValid_ValidateXMLMessage_Should_Throw_NullArgumentException(Type xmlType, string xml)
        {
            // Arrange
            var doc = Activator.CreateInstance(xmlType) as XmlDocument;
            doc.LoadXml(xml);

            // Act
            Action action = () => this._aidxXMLValidator.ValidateAIDXXMLMessage(doc);

            // Assert
            action.Should().Throw<InvalidOperationException>();
        }


        [Fact]
        public void SCHEMA_ACCEPTS_MINIMAL_VALID_Xml()
        {
            Assert.True(this._aidxXMLValidator.ValidateAIDXXMLMessage("DATA/de-ice message/458.dice", false).Any());
        }


        [Theory(Skip = "Redefine the test case")]
        [InlineData("<?xml version='1.0' encoding='UTF-8'?><IATA_AIDX_FlightLegNotifRQ><word>bla bla</word></IATA_AIDX_FlightLegNotifRQ>")]
        [InlineData("<?xml version='1.0' encoding='UTF-8'?><item><name>wrench</name></item>")]
        public void Schema_Rejects_Setting_Type_Without_Name(string xml)
        {
            // Arrange 
            // Act
            var error = this._aidxXMLValidator.ValidateAIDXXMLMessage(xml, true)
                                              .Single();
            //Assert
            error.Severity.Should().Be(XmlSeverityType.Error);
            error.Message.Should().Be("The required attribute 'Name' is missing.");
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

        public void When_AIDXMessageManager_ParseXMLMessage_With_Stream_Should_Return_Type(string xmlPath)
        {
            // Arrange
            var streamReader = new StreamReader(xmlPath);

            // Act
            var message = this._aidxMessageManager.ParseAIDXXMLMessage<IATA_AIDX_FlightLegNotifRQ>(streamReader);

            // Assert
            message.Should().BeOfType<IATA_AIDX_FlightLegNotifRQ>();
        }

        [Fact]
        public void When_AIDXMessageManager_ParseXMLMessage_With_Null_Stream_Should_Throw_ArgumentNullException()
        {
            // Arrange
            StreamReader streamReader = null;

            // Act
            Action action = () => this._aidxMessageManager.ParseAIDXXMLMessage<IATA_AIDX_FlightLegNotifRQ>(streamReader);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }



        [Theory]
        [InlineData("DATA/de-ice message/458.dice")]
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

        public void When_AIDXMessageManager_RunValidation_Should_Return_Error_And_Warnings(string xmlPath)
        {
            // Arrange 
            // Act
            var errors = this._aidxXMLValidator.ValidateAIDXXMLMessage(xmlPath, true);

            var numberOfErrors = errors.Where(err => err.Severity == XmlSeverityType.Error);
            var numberOfWarnings = errors.Where(err => err.Severity == XmlSeverityType.Warning);
            var error = errors.FirstOrDefault();

            //Assert
            numberOfErrors.Count().Should().Be(0);
            numberOfWarnings.Count().Should().BeGreaterOrEqualTo(0);
            error.Severity.Should().NotBe(XmlSeverityType.Error);
            error.Message.Should().NotBe("The required attribute 'Name' is missing.");
        }
    }
}