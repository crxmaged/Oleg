using System;

namespace multiInheritance.CommonClass
{
	class OffspringTwo : OffspringOne
	{ // inheritance second hearacly class OffspringOne for add functional
		string colorFigure;

		public OffspringTwo()
		{
			colorFigure = "undefined";
		}

		public OffspringTwo(string color, string type, double widht, double heigth) : base(type, widht, heigth)
		{ // for class OffspringTwo base class is OffspringOne
			colorFigure = color;
		}

		public void ShowColorFigure()
		{
			Console.WriteLine("Triangle color is: {0}", colorFigure);
		}
	}
}
