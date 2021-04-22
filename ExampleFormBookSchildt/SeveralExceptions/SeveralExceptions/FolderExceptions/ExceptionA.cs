using System;

namespace SeveralExceptions.FolderExceptions
{
	class ExceptionA : Exception
	{
		public ExceptionA()
		{
			// default constructor
		}
		public ExceptionA(string message) : base(message) { }
		public override string ToString()
		{
			return Message;
		}
	}
}
