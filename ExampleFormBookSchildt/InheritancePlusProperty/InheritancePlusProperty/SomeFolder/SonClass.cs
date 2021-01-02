using System;

namespace InheritancePlusProperty.SomeFolder
{
	class SonClass : FatherClass
	{
		public string Style;

		public double Area()
		{ // this method use propertes from father class
			return Width * Height / 2;
		}

		public void ShowStyle()
		{
			Console.WriteLine("Now we have figure with style: {0}", Style);
		}
	}
}
