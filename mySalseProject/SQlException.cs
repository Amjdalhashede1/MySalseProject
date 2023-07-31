using System;
using System.Runtime.Serialization;

namespace mySalseProject
{
    [Serializable]
    internal class SQlException : Exception
    {
        public SQlException()
        {
        }

        public SQlException(string message) : base(message)
        {
        }

        public SQlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SQlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}