using System;

namespace OverloadOperInt.ClassForOverload
{
	class Points
	{
		int x, y, z;

		public Points()
		{
			x = y = z = 0;
		}

		public Points(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Points operator + (Points operLeft, Points operRight)
		{
			Points result = new Points();

			result.x = operLeft.x + operRight.x;
			result.y = operLeft.y + operRight.y;
			result.z = operLeft.z + operRight.z;

			return result;
		}

		public static implicit operator int (Points OneOper)
		{
			return OneOper.x * OneOper.y * OneOper.z;
		}

		public void Show ()
		{
			Console.WriteLine("coordinats x: {0}, y {1}, z {2}", x, y, z);
		}
	}
}
