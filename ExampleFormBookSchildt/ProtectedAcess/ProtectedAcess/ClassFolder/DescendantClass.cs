using System;

namespace ProtectedAcess.ClassFolder
{
	class DescendantClass : BaseClass
	{
		int multiple; // private value

		public void Multiple()
		{ // this fields are protected
			multiple = x * y; 
		}

		public void ShowResult()
		{
			Console.Write("{0}", multiple);
		}
	}
}
