using System;

namespace BoxingUnboxingSecondProg
{
	class Program
	{ // method get any parameter and boxing!
		static int Sqr(object val)
		{ // in the method todo unboxing
			return (int)val * (int)val;
		}

		static void Main(string[] args)
		{
			int x = 22, y;

			y = Sqr(x);

			Console.WriteLine(y);

			Console.ReadLine();

			// Anothe way to show boxing in C#
			Console.WriteLine("Value 22 boxing for what use method ToString, after this result: {0}", 22.ToString());

			Console.ReadLine();
		}
	}
}
