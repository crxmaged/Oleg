using System;
using WorkWithProperty.SomeClass;

namespace WorkWithProperty
{ // this program shows how we use public method if property method 'set' is private
	class Program
	{ // page 320 of book
		static void Main(string[] args)
		{
			PublicClassWithSimpleProperty someAge = new PublicClassWithSimpleProperty();

			Console.WriteLine("Current value {0}", someAge.MyProp);
			Console.WriteLine();

			Console.WriteLine("Now we use increase method");
			someAge.IncrProp();
			Console.WriteLine("Then we have {0}", someAge.MyProp);

			Console.ReadKey();
		}
	}
}
