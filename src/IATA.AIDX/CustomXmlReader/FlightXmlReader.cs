﻿using System.Xml;

namespace IATA.AIDX.CustomXmlReader
{
    /// <summary>
    /// Allows to read the XML file generated by the airlines 
    /// </summary>
    public class FlightXmlReader : XmlTextReader
    {
        public FlightXmlReader(System.IO.TextReader reader) : base(reader)
        {

        }

        /// <summary>
        /// Override the namespace URI to make it available
        /// </summary>
        public override string NamespaceURI
        {
            get { return string.Empty; }
        }
    }

}
