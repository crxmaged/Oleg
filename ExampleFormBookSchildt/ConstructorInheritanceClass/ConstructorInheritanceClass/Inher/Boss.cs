using System;

namespace ConstructorInheritanceClass.Inher
{
	class Boss
	{ // class without constructor
		double width, height;

		public double Width
		{
			get
			{
				return width;
			}
			set
			{
				if (value < 0)
				{ // check negative value
					width = value * (-1);
				}
				else
				{
					width = value;
				}
			}
		}

		public double Height
		{
			get
			{
				return height;
			}
			set
			{
				if (value < 0)
				{ // check negative value
					height = value * (-1);
				}
				else
				{
					height = value;
				}
			}
		}

		public void ShowSize()
		{
			Console.Write("Width: {0} and Height: {1}. ", Width, Height);
		}
	}
}
