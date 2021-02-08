using System;
using FigureOverMethod.NewFolder1;

namespace FigureOverMethod
{
	class Program
	{ // page 361
		static void Main(string[] args)
		{
			BaseFigure[] Shapes = new BaseFigure[5];

			Shapes[0] = new DerivedTriangle("With 90* corner", 16.0, 24.0);
			Shapes[1] = new DerivedRectangle(102);
			Shapes[2] = new DerivedRectangle(22, 10);
			Shapes[3] = new DerivedTriangle(55.5);
			Shapes[4] = new BaseFigure(22, 44, "No shape");

			for(int i = 0; i < Shapes.Length; i++)
			{
				Console.WriteLine("Figure: {0}", Shapes[i].Name);
				Console.WriteLine("Square equale: {0}", Shapes[i].Area());
				Console.WriteLine();
			}

			Console.ReadLine();
 		}
	}
}
