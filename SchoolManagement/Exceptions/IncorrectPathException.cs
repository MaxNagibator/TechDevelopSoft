using System;

namespace SchoolManagement.Exceptions
{
	public class IncorrectPathException : WarningException
	{
		private const string EXCEPTION_MESSAGE_TEMPLATE = "Указан некорректный путь к файлу \"{0}\"";

		public IncorrectPathException(string path)
		{
			Path = path;
		}

		public IncorrectPathException(string path, Exception innerException)
			: base("", innerException)
		{
			Path = path;
		}

		public string Path
		{
			get;
			set;
		}

		public override string Message
		{
			get
			{
				return String.Format(EXCEPTION_MESSAGE_TEMPLATE, Path);
			}
		}
	}
}