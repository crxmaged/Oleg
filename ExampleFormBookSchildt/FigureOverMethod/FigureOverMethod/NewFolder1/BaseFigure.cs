using System;

namespace FigureOverMethod.NewFolder1
{
	class BaseFigure
	{
		double width;
		double height;

		public BaseFigure()
		{
			Width = Height = 0.0;
			Name = "Undefined";
		}

		public BaseFigure (double OneValue, string name )
		{
			Width = Height = OneValue;
			Name = name;
		}

		public BaseFigure(double width, double height, string name)
		{
			Width = width;
			Height = height;
			Name = name;
		}

		public BaseFigure(BaseFigure Object)
		{
			Width = Object.Width;
			Height = Object.Height;
			Name = Object.Name;
		}

		public double Width
		{
			get { return width; } set { width = value < 0 ? value * (-1) : value; }
		}

		public double Height
		{
			get { return height; } set { height = value < 0 ? value * (-1) : value; }
		}

		public string Name { get; set; }

		public void ShowSize ()
		{
			Console.WriteLine("Figure have size of the sides, width: {0} and height: {1}", Width, Height);
		}

		public virtual double Area()
		{ // heve to overload this method is derived class 
			return 0.0;
		}
	}
}
