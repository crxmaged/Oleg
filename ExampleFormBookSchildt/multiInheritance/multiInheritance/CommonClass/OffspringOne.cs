using System;

namespace multiInheritance.CommonClass
{
	class OffspringOne : HeadClass
	{ // inheritance class definition triangle fgure
		string typeTriangle;

		public OffspringOne()
		{
			typeTriangle = "undefined";
		}

		public OffspringOne(double val) : base(val)
		{
			typeTriangle = "two sides are the same size";
		}

		public OffspringOne(string typeFigure, double widht, double heigth) : base (widht, heigth)
		{
			typeTriangle = typeFigure;
		}

		public double Area()
		{
			return Heigth * Widht / 2;
		}

		public void ShowTypeTriagle()
		{
			Console.WriteLine("Triagle type: {0}", typeTriangle);
		}
	}
}
