using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Iata.Aidx.UnitTests.Library.FakeObjects
{
    public class FakeXMLFactory : IEnumerable<object[]>
    {
        private readonly IEnumerable<object[]> _data = new List<object[]>()
        {
            null,
            new object[]{ MockXML.GetMockXML()},
            new object[]{MockXML.GetMockXML("<item><name>wrench</name></item>") }
        };


        public IEnumerator<object[]> GetEnumerator()
        {
            return this._data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._data.GetEnumerator();
        }
    }


    internal static class MockXML
    {
        public static XmlDocument GetMockXML(string data = null)
        {
            var doc = new XmlDocument();

            if (data != null)
                doc.LoadXml(data);
            return doc;
        }
    }
}
