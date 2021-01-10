using System;
using ConstructorInheritanceClass.Inher;

namespace ConstructorInheritanceClass
{
	class Program
	{ // page 338
		static void Main(string[] args)
		{ // Pisduk have user constructor now we use it
			Pisduk maloe1 = new Pisduk("Same sides", 8.4, 8.4);
			Pisduk maloe2 = new Pisduk("With 90 corner", 8.0, 12.0);
			// we use constructor from inheritance class. Boss class don't have user constructor
			Console.Write("Information about first figure: ");
			maloe1.ShowType();
			Console.WriteLine();
			maloe1.ShowSize();
			Console.WriteLine("Square of figure is {0}", maloe1.Area());
			Console.WriteLine();
			Console.Write("Information about second figure: ");
			maloe2.ShowType();
			Console.WriteLine();
			maloe2.ShowSize();
			Console.WriteLine("Square of figure is {0}", maloe2.Area());

			Console.ReadLine();
		}
	}
}
