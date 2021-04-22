using System;
using CreateUserCatchException.Folder;

namespace CreateUserCatchException.Folder
{
	// Create user exception with inheritance Excetion
	class RangeArrayException : Exception
	{ // this class is desedent from class Exception
		/* override all constructor from Exception class (base) 
		 without anothe realizations */
		public RangeArrayException() : base() { }
		public RangeArrayException(string str) : base(str) { }
		public RangeArrayException(string str, Exception inner) : base(str, inner) { }
		protected RangeArrayException(System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext streamContex) : base(serInfo, streamContex) { }
		// Override for this class RangeArrayException
		public override string ToString()
		{
			return Message;
		}
	}
}
