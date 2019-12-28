using System;

namespace UseCustomClassType.MyClassTypes
{
	class UseThisClass
	{
		int w, h;

		public UseThisClass() { }
		
		public UseThisClass(int wieght, int hiegth)
		{
			w = wieght;
			h = hiegth;
		}

		public void Show()
		{
			Console.WriteLine(w + " " + h);
		}

		public int Area ()
		{
			return w * h;
		}

		public UseThisClass Factor (int fact)
		{
			return new UseThisClass(w * fact, h * fact);
		}
	}
}
