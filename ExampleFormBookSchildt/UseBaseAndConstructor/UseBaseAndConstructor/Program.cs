using System;
using UseBaseAndConstructor.ClassFolder;

namespace UseBaseAndConstructor
{
	class Program
	{ // page 339
		static void Main(string[] args)
		{ // this program shows how can use base constructor from base class
			// in inheritance class with user constructor just see it
			LessClass FirstObj = new LessClass("same sides", 10.0, 10.0);
			LessClass SecondObj = new LessClass("90* corner", 16.0, 24.0);

			Console.WriteLine("What we have about first figure: ");
			FirstObj.ShowStyle();
			FirstObj.ShowSize();
			Console.WriteLine("Square of figure is: {0}", FirstObj.Area());

			Console.WriteLine();

			Console.WriteLine("What we have about first figure: ");
			SecondObj.ShowStyle();
			SecondObj.ShowSize();
			Console.WriteLine("Square of figure is: {0}", SecondObj.Area());

			Console.ReadKey();
		}
	}
}
