using System;

namespace FigureOverMethod.NewFolder1
{
	class DerivedRectangle : BaseFigure
	{
		public DerivedRectangle() : base ()
		{
		}

		public DerivedRectangle(double width, double height) : base (width, height, "Rectangle")
		{
		}

		public DerivedRectangle(double OneValue) : base (OneValue, "Rectangle")
		{
		}

		public DerivedRectangle(DerivedRectangle Object) : base (Object)
		{
		}

		public bool IsSquare()
		{
			if (Width == Height)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override double Area()
		{
			return Width * Height;
		}
	}
}
