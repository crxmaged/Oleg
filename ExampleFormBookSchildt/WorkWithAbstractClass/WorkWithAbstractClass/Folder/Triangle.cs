using System;

namespace WorkWithAbstractClass.Folder
{
	class Triangle : Figure
	{
		string styleTriangle;

		public Triangle ()
		{
			styleTriangle = "undefined";
		}

		public Triangle (double OneValue) : base (OneValue, "Triangle")
		{
			styleTriangle = "equale 2 sides";
		}

		public Triangle (string style, double width, double height) : base (width, height, "Triangle")
		{
			styleTriangle = style;
		}

		public Triangle (Triangle ObjectTriangle) : base (ObjectTriangle)
		{
			styleTriangle = ObjectTriangle.styleTriangle;
		}

		public override double Area()
		{
			return Width * Height / 2;
		}

		public void TriagleStyle ()
		{
			Console.WriteLine("Triagle have style: {0}", styleTriangle);
		}
	}
}
