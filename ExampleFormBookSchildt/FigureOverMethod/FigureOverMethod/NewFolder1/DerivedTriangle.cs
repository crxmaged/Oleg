using System;

namespace FigureOverMethod.NewFolder1
{
	class DerivedTriangle : BaseFigure
	{
		string styleTriangle;

		public DerivedTriangle ()
		{
			styleTriangle = "Undefined";
		}

		public DerivedTriangle(double OneValue) : base ( OneValue, "Triangle")
		{
			styleTriangle = "Same sides";
		}

		public DerivedTriangle(string styleTriangle, double width, double height) : base(width, height, "Triangle")
		{
			this.styleTriangle = styleTriangle;
		}

		public DerivedTriangle(DerivedTriangle Object) : base (Object)
		{
			this.styleTriangle = Object.styleTriangle;
		}

		public override double Area()
		{
			return Width * Height / 2;
		}

		public void TriagleStyle()
		{
			Console.WriteLine("Triagle have styel: {0}", styleTriangle);
		}
	}
}
