using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Exceptions
{
	public class ReportExecutionException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE = "Во время выполнения отчета произошла ошибка: {0}";

		public ReportExecutionException(string reportError, Exception innerException)
			: base("", innerException)
		{
			ReportError = reportError;
		}

		public string ReportError
		{
			get;
			set;
		}

		public override string Message
		{
			get
			{
				return String.Format(EXCEPTION_MESSAGE_TEMPLATE, ReportError);
			}
		}
	}
}
