using System;
using UseObjectInConsructor.ComminClass;

namespace UseObjectInConsructor
{ // this program shows how we can copy object use constructor 
	class Program
	{ // page 353 
		static void Main(string[] args)
		{
			OffspringClass FirstObj = new OffspringClass("same sides", 10.0, 10.0);
			OffspringClass SecondObj;

			OffspringClass ThirdObj = new OffspringClass("with 90* corner", 8.0, 12.0);

			Console.WriteLine("We have in : ");
			FirstObj.ShowSize();
			Console.WriteLine("Square of the figure is: {0}", FirstObj.Area());
			FirstObj.ShowStyleFigure();
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Now we coped values Triangle #1 to Triangle #2");
			SecondObj = new OffspringClass(FirstObj); // set values triangle #1 to
			// triangle #2
			Console.WriteLine("Triangle #2 equal: ");
			SecondObj.ShowSize();
			Console.WriteLine("Square of the figure is: {0}", SecondObj.Area());
			SecondObj.ShowStyleFigure();
			Console.WriteLine("-------------------------------");
			// This step change all values Triangle #1
			Console.WriteLine("Then we change values in Triangle #1");
			FirstObj = new OffspringClass(ThirdObj);
			Console.WriteLine("-------------------------------");

			Console.WriteLine("We have in Triangle #1 : ");
			FirstObj.ShowSize();
			Console.WriteLine("Square of the figure is: {0}", FirstObj.Area());
			FirstObj.ShowStyleFigure();
			Console.WriteLine("-------------------------------");

			Console.WriteLine("But Triangle #2 equal: ");
			SecondObj.ShowSize();
			Console.WriteLine("Square of the figure is: {0}", SecondObj.Area());
			SecondObj.ShowStyleFigure();

			Console.ReadKey();
		}
	}
}
