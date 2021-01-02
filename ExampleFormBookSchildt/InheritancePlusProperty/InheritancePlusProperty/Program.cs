using System;
using InheritancePlusProperty.SomeFolder;

namespace InheritancePlusProperty
{
	class Program
	{ // page of book 334
		static void Main(string[] args)
		{
			SonClass eXOne = new SonClass();
			SonClass eXTwo = new SonClass();

			eXOne.Width = 10.0;
			eXOne.Height = 10.0;
			eXOne.Style = "Same sides";

			eXTwo.Width = 8.0;
			eXTwo.Height = 12.0;
			eXTwo.Style = "With 90* corner";

			Console.WriteLine("What we have: ");
			eXOne.ShowStyle(); // use son class method
			eXOne.SizeOfFigure(); // use father class method in first example
			Console.WriteLine("Square of figure is: {0}", eXOne.Area());

			Console.WriteLine("What we have: ");
			eXTwo.ShowStyle(); // use son class method
			eXTwo.SizeOfFigure(); // use father class method in second example
			Console.WriteLine("Square of figure is: {0}", eXTwo.Area());

			Console.ReadKey();
		}
	}
}
