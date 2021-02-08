using System;

namespace WorkWithAbstractClass.Folder
{
	abstract class Figure
	{
		double width, height;

		public Figure()
		{
			Width = Height = 0.0;
			Name = "Undefined";
		}

		public Figure(double OneValue, string name)
		{
			Width = Height = OneValue;
			Name = name;
		}

		public Figure(double width, double height, string name)
		{
			Width = width;
			Height = height;
			Name = name;
		}

		public Figure(Figure Object)
		{ // copy object
			Width = Object.Width;
			Height = Object.Height;
			Name = Object.Name;
		}

		public double Width
		{
			get { return this.width; }
			set { width = value < 0 ? value * (-1) : value; }
		}

		public double Height
		{
			get { return this.height; }
			set { height = value < 0 ? value * (-1) : value; }
		}

		public string Name { get; set; }

		public void ShowSize()
		{
			Console.WriteLine("Width: {0} and Height: {1}", Width, Height);
		}

		public abstract double Area(); // abstract Method
	}
}
