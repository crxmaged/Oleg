using System;
using multiInheritance.CommonClass;

namespace multiInheritance
{
	class Program
	{ // page 348
		static void Main(string[] args)
		{
			OffspringTwo objOne = new OffspringTwo("Black", "90* corner", 16.0, 32.0);
			OffspringTwo objTwo = new OffspringTwo("Red", "same two sides", 22.0, 22.0);

			Console.WriteLine("Show what we have!");
			Console.WriteLine("First Object have: ");
			objOne.ShowTypeTriagle();
			objOne.ShowSizeFigure();
			objOne.ShowColorFigure();
			Console.WriteLine("Square equal: {0}", objOne.Area());

			Console.WriteLine("Second Object have: ");
			objTwo.ShowTypeTriagle();
			objTwo.ShowSizeFigure();
			objTwo.ShowColorFigure();
			Console.WriteLine("Square equal: {0}", objTwo.Area());

			Console.ReadLine();
		}
	}
}
