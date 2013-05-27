using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces.Exceptions
{
	public class PropertyNotSettedException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE =
			"Для работы данной функции необходимо задать параметр {0} в системных настройках программы";

		public PropertyNotSettedException(string propertyName)
		{
			PropertyName = propertyName;
		}

		public PropertyNotSettedException(string propertyName, Exception innerException)
			: base("", innerException)
		{
			PropertyName = propertyName;
		}

		public string PropertyName
		{
			get;
			set;
		}

		public override string Message
		{
			get
			{
				return String.Format(EXCEPTION_MESSAGE_TEMPLATE, PropertyName);
			}
		}
	}
}
