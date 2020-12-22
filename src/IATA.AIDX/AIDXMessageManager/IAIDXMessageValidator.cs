using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace IATA.AIDX.AIDXMessageManager
{
    public interface IAIDXMessageValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        void ValidateAIDXXMLMessage(XmlDocument document);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputXml"></param>
        /// <param name="includeHelperSchema"></param>
        /// <returns></returns>
        IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(string inputXml, bool includeHelperSchema);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputXml"></param>
        /// <param name="includeHelperSchema"></param>
        /// <returns></returns>
        IEnumerable<ValidationEventArgs> ValidateAIDXXMLMessage(StreamReader inputXml, bool includeHelperSchema);
    }
}
