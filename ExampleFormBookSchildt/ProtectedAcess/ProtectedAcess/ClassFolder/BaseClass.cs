using System;

namespace ProtectedAcess.ClassFolder
{
	class BaseClass
	{
		protected int x, y; // this fields are protected 
		// but steal use in inheritance class
		public void Set (int a, int b)
		{
			x = a;
			y = b;
		}

		public void Show()
		{
			Console.WriteLine("First value: {0}, second value: {1}", x, y);
		}
	}
}
