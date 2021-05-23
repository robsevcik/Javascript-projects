using System;
using System.Runtime.Serialization;

namespace exception_handling
{
    [Serializable]
    internal class DividedByZeroException : Exception
    {
        public DividedByZeroException()
        {
        }

        public DividedByZeroException(string message) : base(message)
        {
        }

        public DividedByZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DividedByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}