using System;

namespace UseBaseAndConstructor.ClassFolder
{
	class BaseClass
	{
		double width, height;

		public BaseClass()
		{
			// default constructor
		}

		public BaseClass(double width, double height)
		{ // user constructor helps us to set and value of figure :)
			Width = width;
			Height = height;
		}
		// just properties
		public double Width { get { return this.width; } set { this.width = value < 0 ? (-1) * value : value; } }

		public double Height { get { return this.height; } set { this.height = value < 0 ? (-1) * value : value; } }

		public void ShowSize()
		{
			Console.WriteLine("Size of figure width: {0} and height: {1}", Width, Height);
		}
	}
}
