using System;

namespace ExceptionConstructors.Folder
{
	class Xclass
	{
		int val;
		public Xclass()
		{ // default constructor

		}
		public Xclass(int paramArg)
		{ // user constructor
			val = paramArg;
		}

		public int AddVal (Xclass xVal)
		{ // method take one param type thies class
			return val + xVal.val;
		}
	}
}
