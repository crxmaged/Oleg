using System;

namespace OverloadConstructorsUseBase.FolderForTwoClass
{
	class ClassBase
	{ // base class for all figures
		double width;
		double height;

		public ClassBase ()
		{
			Width = Height = 0.0;
		}

		public ClassBase (double oneSize)
		{
			Width = Height = oneSize;
		}

		public ClassBase (double width, double height)
		{
			Width = width;
			Height = height;
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

		public void ShowSizes ()
		{
			Console.WriteLine("Figure have height: {0}, and width {1}", Height, Width);
		}
	}
}
