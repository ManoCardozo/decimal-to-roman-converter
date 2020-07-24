using System;
using System.Runtime.Serialization;

namespace DecimalToRomanConverter.Application.Exceptions
{
    [Serializable()]
    public class OutOfRomanNumeralBoundsException : Exception
    {
        public OutOfRomanNumeralBoundsException() : base() { }

        public OutOfRomanNumeralBoundsException(string message) : base(message) { }

        public OutOfRomanNumeralBoundsException(string message, Exception inner) : base(message, inner) { }

        protected OutOfRomanNumeralBoundsException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
