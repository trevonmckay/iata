using IATA.AIDX.AIDXMessageManager;
using System;
using System.IO;

namespace IATA.AIDX
{

    /// <summary>
    /// 
    /// In general, each time a data sender composes and sends an AIDX message it shall be subject
    /// to XML validation before the message is transmitted.
    /// In general, each time a receiver receives an AIDX message it should be subject to schema
    /// validation.
    /// 1. Validate the AIDX message
    /// 2. Process(Parse) AIDX message
    /// 3. Send AIDX message Response to the Sender
    /// </summary>
    /// 

    public interface IAIDXService
    {
        T ProcessAIDXMessage<T>(string xmlMessagePath) where T : class;


    }

    public class AIDXService : IAIDXService
    {
        private readonly IAIDXMessageManager _manager;
        private readonly IAIDXMessageValidator _validator;
        public AIDXService()
        {
            var obj = new AIDXManager();
            _manager = obj;
            _validator = obj;
        }

        public T ProcessAIDXMessage<T>(string xmlMessagePath) where T : class
        {
            if (string.IsNullOrEmpty(xmlMessagePath))
            {
                throw new ArgumentNullException();
            }

            // Define what to do with warnings and errors
            var validationEventResults = _validator.ValidateAIDXXMLMessage(xmlMessagePath, true);

            // Arrange
            var streamReader = new StreamReader(xmlMessagePath);
            return _manager.ParseAIDXXMLMessage<T>(streamReader);
        }
    }
}
