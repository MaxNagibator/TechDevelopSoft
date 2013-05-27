using System;

namespace Interfaces.Exceptions
{
	public class ComponentNotInstalledException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE =
			"Для работы данной функции необходим установленный компонент {0}";

		public ComponentNotInstalledException(string componentName)
		{
			ComponentName = componentName;
		}

		public ComponentNotInstalledException(string componentName, Exception innerException)
			: base("", innerException)
		{
			ComponentName = componentName;
		}

		public string ComponentName
		{
			get;
			set;
		}

		public override string Message
		{
			get
			{
				return String.Format(EXCEPTION_MESSAGE_TEMPLATE, ComponentName);
			}
		}
	}
}