using System;
using System.Runtime.Serialization;

namespace BankAppLibrary
{
    [Serializable]
    public class InssucciffientBalanceException : Exception
    {
        public InssucciffientBalanceException()
        {
        }

        public InssucciffientBalanceException(string message) : base(message)
        {
        }

        public InssucciffientBalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InssucciffientBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}