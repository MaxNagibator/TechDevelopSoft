using System;

namespace Interfaces.Exceptions
{
    public class ResultIsNotInt32Exception : WarningException
    {
        private const string EXCEPTION_MESSAGE_TEMPLATE = "Int32 не является типом полученного результата: \"{0}\"";

        public ResultIsNotInt32Exception(object result)
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
