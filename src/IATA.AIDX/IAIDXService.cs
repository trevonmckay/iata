using System.Threading.Tasks;
using System.Xml;

namespace IATA.AIDX
{

    /// <summary>
    /// 
    /// In general, each time a data sender composes and sends an AIDX message it shall be subject
    /// to XML validation before the message is transmitted.
    /// In general, each time a receiver receives an AIDX message it should be subject to schema
    /// validation.
    /// </summary>
    /// 

    public interface IAIDXService
    {
        Task ProcessAIDXMessage(XmlDocument document);


    }
}
