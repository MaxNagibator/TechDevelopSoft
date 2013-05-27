using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Exceptions
{
	public class LowRightsException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE =
			"Для выполнения указанного действия необходимы дополнительные разрешения на локальном компьютере";

		public LowRightsException()
			: base(EXCEPTION_MESSAGE_TEMPLATE, null)
		{
		}
	}
}
