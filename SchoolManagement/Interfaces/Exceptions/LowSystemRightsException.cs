using System;

namespace Interfaces.Exceptions
{
	public class LowSystemRightsException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE =
			"Для выполнения указанного действия необходимы дополнительные разрешения на локальном компьютере";

		public LowSystemRightsException(Exception innerException)
			: base(EXCEPTION_MESSAGE_TEMPLATE, innerException)
		{
		}
	}
}
