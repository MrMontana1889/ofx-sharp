using System;
using System.Runtime.Serialization;

namespace OFXImporter
{
    [Serializable]
    public class OFXException : Exception
    {
        public OFXException()
        {
        }

        public OFXException(string message) : base(message)
        {
        }

        public OFXException(string message, Exception inner) : base(message, inner)
        {
        }

        protected OFXException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }

    [Serializable]
    public class OFXParseException : OFXException
    {
        public OFXParseException()
        {
        }

        public OFXParseException(string message) : base(message)
        {
        }

        public OFXParseException(string message, Exception inner) : base(message, inner)
        {
        }

        protected OFXParseException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}