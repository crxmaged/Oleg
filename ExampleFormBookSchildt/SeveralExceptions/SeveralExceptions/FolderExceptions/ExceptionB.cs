using System;

namespace SeveralExceptions.FolderExceptions
{
	class ExceptionB : Exception
	{
		public ExceptionB()
		{
			// default constructor
		}
		public ExceptionB(string message) : base(message) { }
		public override string ToString()
		{
			return Message;
		}
	}
}
