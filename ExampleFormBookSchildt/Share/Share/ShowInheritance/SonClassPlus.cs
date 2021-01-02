using System;

namespace Share.ShowInheritance
{
	class SonClassPlus : FatherClass
	{
		public bool IsSuare()
		{
			if (Height == Width)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public double Area()
		{
			return Height * Width;
		}
	}
}
