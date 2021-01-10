using System;
using OverloadConstructorsUseBase.FolderForTwoClass;

namespace OverloadConstructorsUseBase
{
	class Program
	{ // page 341
		static void Main(string[] args)
		{
			ClassInheritance Triangle1 = new ClassInheritance();
			ClassInheritance Triangle2 = new ClassInheritance("triangle with 90* corner", 16.0, 14.0);
			ClassInheritance Triangle3 = new ClassInheritance(10.0);

			Triangle1 = Triangle2;

			Console.WriteLine("Triangle #1 have:");
			Triangle1.ShowStyleTriangle();
			Triangle1.ShowSizes();
			Console.WriteLine("Square equale: {0}", Triangle1.Area());
			Console.WriteLine();

			Console.WriteLine("Triangle #2 have:");
			Triangle2.ShowStyleTriangle();
			Triangle2.ShowSizes();
			Console.WriteLine("Square equale: {0}", Triangle2.Area());
			Console.WriteLine();

			Console.WriteLine("Triangle #3 have:");
			Triangle3.ShowStyleTriangle();
			Triangle3.ShowSizes();
			Console.WriteLine("Square equale: {0}", Triangle3.Area());
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
