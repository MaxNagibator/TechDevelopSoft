using System;
using System.Data.SqlClient;

namespace SchoolManagement.Exceptions
{
    public class SqlProviderException : WarningException
    {
        private const string EXCEPTION_MESSAGE_TEMPLATE = "Во время выполнения запроса произошла ошибка: {0}";

        public SqlProviderException(SqlException innerException)
            : base("", innerException)
        {
        }

        public override string Message
        {
            get
            {
                return String.Format(EXCEPTION_MESSAGE_TEMPLATE, InnerException.Message);
            }
        }
    }
}
