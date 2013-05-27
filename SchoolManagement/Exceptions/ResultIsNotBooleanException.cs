using System;

namespace SchoolManagement.Exceptions
{
    class ResultIsNotBooleanException : WarningException
    {
        private const string EXCEPTION_MESSAGE_TEMPLATE = "Boolean не является типом полученного результата: \"{0}\"";

        public ResultIsNotBooleanException(object result)
        {
            Result = result;
        }

        public object Result
        {
            get;
            set;
        }

        public override string Message
        {
            get
            {
                return String.Format(EXCEPTION_MESSAGE_TEMPLATE, "" + Result);
            }
        }
    }
}
