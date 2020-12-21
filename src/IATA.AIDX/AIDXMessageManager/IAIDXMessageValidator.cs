using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace IATA.AIDX.AIDXMessageManager
{
    public interface IAIDXMessageValidator
    {
        void ValidateAIDXXMLMessage(XmlDocument document);
        IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(string inputXml, bool includeHelperSchema);
        IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(StreamReader inputXml, bool includeHelperSchema);
    }
}
