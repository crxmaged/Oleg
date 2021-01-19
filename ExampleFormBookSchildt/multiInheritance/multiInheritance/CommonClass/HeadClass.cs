using System;

namespace multiInheritance.CommonClass
{
	class HeadClass
	{
		double widht;
		double heigth;

		public HeadClass()
		{
			Widht = Heigth = 0.0;
		}

		public HeadClass(double val)
		{
			Widht = Heigth = val;
		}

		public HeadClass(double widht, double heigth)
		{
			this.heigth = heigth;
			this.widht = widht;
		}

		public double Widht
		{
			get { return this.widht; }
			set { this.widht = value < 0 ? value * (-1) : value; }
		}

		public double Heigth
		{
			get { return this.heigth; }
			set { this.heigth = value < 0 ? value * (-1) : value; }
		}

		public void ShowSizeFigure()
		{
			Console.WriteLine("Figure have size, widht: {0} and heigth: {1}", Widht, Heigth);
		}
	}
}
