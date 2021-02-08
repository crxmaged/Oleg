using System;
using WorkWithAbstractClass.Folder;

namespace WorkWithAbstractClass
{
	class Program
	{ // page 366
		static void Main(string[] args)
		{
			Figure[] Shapes = new Figure[4];

			Shapes[0] = new Triangle("Triangle with 90* corner", 16.0, 24.0);
			Shapes[1] = new Rectangle(10.0);
			Shapes[2] = new Triangle(77.0);
			Shapes[3] = new Rectangle("Simple Rectangle", 11.0, 12.0);

			// Figure Test = new Figure();
			// Can't create object from abstract class 

			for(int i = 0; i < Shapes.Length; i++)
			{
				Console.WriteLine("We have object: {0}", Shapes[i].Name);
				Console.WriteLine("This figure have square: {0}", Shapes[i].Area());

				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
