using System;

namespace InheritancePlusProperty.SomeFolder
{
	class FatherClass
	{
		double width; // private field
		double height; // private too

		// Use property
		public double Width // use open(public) property with check of value
		{
			get { return width; }
			set { width = value < 0 ? -value : value; } // if value < 0, multiple to (-1)
		}

		public double Height // use open(public) property with check of value 
		{
			get { return height; }
			set { height = value < 0 ? -value : value; } // if value < 0, multiple to (-1)
		}

		public void SizeOfFigure () // Method shows size of figure
		{
			Console.WriteLine("Width is: {0} and height is: {1}", Width, Height);
		}
	}
}
