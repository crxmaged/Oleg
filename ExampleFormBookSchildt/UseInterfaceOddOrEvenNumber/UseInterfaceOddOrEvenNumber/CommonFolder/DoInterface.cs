using System;

namespace UseInterfaceOddOrEvenNumber.CommonFolder
{ // this class execute Interface and call this members
	class DoInterface : INumber
	{ // new way to call members from Interface
		bool INumber.IsOdd(int number) // ececute method from Interface 
		{  // where can call after dot
			if ((number%2) != 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		// method IsOdd is private in this class
		public bool IsEven(int number)
		{ // use 'this' to call himself interface referance
			INumber MyObject = this; // can use execute components of Interface in this class
			return !MyObject.IsOdd(number); // method IsOdd executed in this class 
		}
	}
}
