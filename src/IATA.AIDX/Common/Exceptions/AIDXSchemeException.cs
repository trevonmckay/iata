using System;

namespace IATA.AIDX.Common.Exceptions
{
    public class AIDXSchemeException : Exception
    {
        public AIDXSchemeException()
            : base()
        {

        }

        public AIDXSchemeException(string message)
            : base(message)
        {

        }
    }
}
