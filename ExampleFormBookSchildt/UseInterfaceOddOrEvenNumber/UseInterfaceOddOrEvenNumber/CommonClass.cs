using System;
using UseInterfaceOddOrEvenNumber.CommonFolder;

namespace UseInterfaceOddOrEvenNumber
{
	class CommonClass
	{ // page 389
		static void Main(string[] args)
		{
			DoInterface ExeObject = new DoInterface();
			bool result;
			int numberEven = 10, numberOdd = 9;

			result = ExeObject.IsEven(numberEven);
			if (result)
			{
				Console.WriteLine("Variable 'numberEven' have even number!");
			}

			// result = ExeObject.IsOdd(number); - can not run because method IsOdd private is class DoInterface
			// If we want to call method IsOdd here need upcast class DoInterface to Interface INumber
			// all members is Interface are public
			INumber IRef = (INumber)ExeObject;
			// IsOdd is private but can call this method from Interface
			result = IRef.IsOdd(numberOdd);
			if (result)
			{
				Console.WriteLine("Variable 'numberOdd' have Odd number!");
			}

			Console.ReadLine();
		}
	}
}
