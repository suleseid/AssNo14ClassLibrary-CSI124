using System;
using System.Runtime.Serialization;

namespace AssNo14ClassLibrary_CSI124
{
    [Serializable]
    internal class diceRollException : Exception
    {
        public diceRollException()
        {
        }

        public diceRollException(string? message) : base(message)
        {
        }

        public diceRollException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected diceRollException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}