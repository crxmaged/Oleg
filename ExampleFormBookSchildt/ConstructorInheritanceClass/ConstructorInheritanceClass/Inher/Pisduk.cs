using System;

namespace ConstructorInheritanceClass.Inher
{
	class Pisduk : Boss
	{
		string NameFigure;
		// Constructor in inheritance class
		public Pisduk()
		{
			// default constructor
		}

		public Pisduk (string name, double w, double h)
		{
			Width = w;
			Height = h;
			NameFigure = name;
		}
		// Calculate square of figure
		public double Area()
		{
			return Width * Height / 2;
		}
		// Show type of figure
		public void ShowType()
		{
			Console.Write("We have: {0}", NameFigure);
		}
	}
}
