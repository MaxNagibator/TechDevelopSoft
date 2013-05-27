using System;

namespace SchoolManagement.Exceptions
{
    public class WarningException : Exception
    {
        public WarningException()
        {
        }

        public WarningException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
