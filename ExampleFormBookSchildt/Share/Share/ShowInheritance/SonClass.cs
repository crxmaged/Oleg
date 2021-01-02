using System;

namespace Share.ShowInheritance
{
	class SonClass : FatherClass
	{
		public string sTyle; // Style of figure

		public double Area ()
		{
			return Width * Height / 2;
		}

		public void ShowStyle()
		{
			Console.WriteLine("Figure is: {0}", sTyle);
		}
	}
}
