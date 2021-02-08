using System;
using OverrideMethod.CommonClass;

namespace OverrideMethod
{
	class Program
	{ // page 356
		static void Main(string[] args)
		{ // This program shows how work override virtual method
			BaseClass BaseObject = new BaseClass();
			DerivedClass DerivedObject = new DerivedClass();
			OffspringClass OffspringObject = new OffspringClass();

			BaseClass RefObject;
			RefObject = BaseObject;
			Console.WriteLine("BaseClass");
			RefObject.Try();
			Console.WriteLine();

			RefObject = DerivedObject;
			Console.WriteLine("DerivedClass");
			RefObject.Try();
			Console.WriteLine();

			RefObject = OffspringObject;
			Console.WriteLine("OffspringClass");
			RefObject.Try();

			Console.ReadKey();

		}
	}
}
