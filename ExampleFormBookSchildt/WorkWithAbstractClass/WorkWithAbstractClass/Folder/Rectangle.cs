using System;

namespace WorkWithAbstractClass.Folder
{
	class Rectangle : Figure
	{
		string rectangleStyle;

		public Rectangle()
		{
			rectangleStyle = "undefined";
		}

		public Rectangle(double OneValue) : base(OneValue, "Rectangle")
		{
			rectangleStyle = "Rectangle is square";
		}

		public Rectangle(string style, double width, double height) : base(width, height, "Rectangle")
		{
			rectangleStyle = style;
		}

		public Rectangle(Rectangle ObjectRectangle) : base(ObjectRectangle)
		{
			Width = ObjectRectangle.Width;
			Height = ObjectRectangle.Height;
			rectangleStyle = ObjectRectangle.rectangleStyle;
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
