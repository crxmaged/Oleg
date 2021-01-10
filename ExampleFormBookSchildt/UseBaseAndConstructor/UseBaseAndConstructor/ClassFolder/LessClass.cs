using System;

namespace UseBaseAndConstructor.ClassFolder
{
	class LessClass : BaseClass
	{
		string style = "No set";

		public LessClass()
		{
			// default constructor
		}
		// user construstor where we use send parameters w and h to base constructor 
		public LessClass(string style, double w, double h) : base (w, h)
		{
			this.style = style;
		}
		// methed count area of figure
		public double Area ()
		{
			return (base.Width * base.Height) / 2;
		}

		public void ShowStyle()
		{
			Console.WriteLine("The figure have style: {0}", style);
		}
	}
}
