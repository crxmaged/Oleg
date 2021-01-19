using System;

namespace UseObjectInConsructor.ComminClass
{
	class OffspringClass : BaseClass
	{
		string styleFigukre;

		public OffspringClass ()
		{
			styleFigukre = "undefined";
		}

		public OffspringClass (double val) : base (val)
		{
			styleFigukre = "equel sides";
		}

		public OffspringClass (string style, double width, double height) : base (width, height)
		{
			styleFigukre = style;
		}

		public OffspringClass (OffspringClass obj) : base (obj)
		{
			styleFigukre = obj.styleFigukre;
		}

		public double Area ()
		{
			return Width * Height / 2;
		}

		public void ShowStyleFigure()
		{
			Console.WriteLine("Triangle have style: {0}", styleFigukre);
		}
	}
}
