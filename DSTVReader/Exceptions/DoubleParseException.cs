using System;
using System.Globalization;
using DSTV.Implementations;

namespace DSTV.Exceptions
{
    public class DoubleParseException : ParseException
    {
        public DoubleParseException(ReaderContext context) : base(context,
            string.Format(CultureInfo.InvariantCulture, Constants.DoubleParseExceptionMessage, context?.LineNumber))
        {
        }

        protected DoubleParseException(ReaderContext context, string message) : base(context, message)
        {
        }

        protected DoubleParseException()
        {
        }

        protected DoubleParseException(string? message) : base(message)
        {
        }

        protected DoubleParseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}