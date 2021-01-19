using System;

namespace UseObjectInConsructor.ComminClass
{
	class BaseClass
	{
		double width;
		double height;

		public BaseClass()
		{
			Width = Height = 0.0;
		}

		public BaseClass (double val)
		{
			Width = Height = val;
		}

		public BaseClass (double width, double height)
		{
			Width = width;
			Height = height;
		}
		// copy object use constructor
		public BaseClass (BaseClass obj)
		{
			Width = obj.Width;
			Height = obj.Height;
		}

		public double Width
		{
			get { return this.width; }
			set { this.width = value < 0 ? value * (-1) : value; }
		}

		public double Height
		{
			get { return this.height; }
			set { this.height = value < 0 ? value * (-1) : value; }
		}

		public void ShowSize()
		{
			Console.WriteLine("Figure have width: {0} and height: {1}", Width, Height);
		}
	}
}
