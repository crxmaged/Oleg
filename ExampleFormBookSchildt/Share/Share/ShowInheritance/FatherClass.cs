using System;

namespace Share.ShowInheritance
{
	class FatherClass
	{
		public double Width;
		public double Height;

		public void ShowSize()
		{
			Console.WriteLine("We have figure with widht: {0} and height: {1}", Width, Height);
		}
	}
}
