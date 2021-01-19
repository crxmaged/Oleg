using System;

namespace OverloadConstructorsUseBase.FolderForTwoClass
{
	class ClassInheritance : ClassBase
	{ // figure triangle
		string style;

		public ClassInheritance ()
		{
			style = "undefined";
		}
		// arguments width and height send to base constructor 
		public ClassInheritance(string style, double width, double height) : base (width, height)
		{
			this.style = style;
		}
		// argument oneSize send to base constructor
		public ClassInheritance (double oneSize) : base (oneSize)
		{
			this.style = "equalles sides";
		}

		public double Area()
		{
			return Width * Height / 2;
		}

		public void ShowStyleTriangle()
		{
			Console.WriteLine("Triangle have style: {0}", style);
		}
	}
}
