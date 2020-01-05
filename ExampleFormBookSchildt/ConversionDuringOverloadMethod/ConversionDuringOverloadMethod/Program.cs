using System;
using ConversionDuringOverloadMethod.Methods;

namespace ConversionDuringOverloadMethod
{
	class Program
	{ // Use Method from class "DifferentMetodsWithSameName"
		static void Main(string[] args)
		{
			byte b = 10;
			int i = 222;
			short s = - 32000;
			double d = 10.555;
			float f = 12.2f;

			DifferentMetodsWithSameName value = new DifferentMetodsWithSameName();

			value.Method(b);
			value.Method(i);
			value.Method(s);
			value.Method(d);
			value.Method(f);

			Console.ReadLine();
		}
	}
}
