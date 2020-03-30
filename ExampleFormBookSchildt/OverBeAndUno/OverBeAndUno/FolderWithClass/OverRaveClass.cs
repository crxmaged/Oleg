using System;

namespace OverBeAndUno.FolderWithClass
{
	class OverRaveClass
	{
		int x, y, z;

		public OverRaveClass()
		{
			x = y = z = 0;
		}

		public OverRaveClass (int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static OverRaveClass operator + (OverRaveClass first, OverRaveClass second)
		{
			OverRaveClass result = new OverRaveClass();

			result.x = first.x + second.x;
			result.y = first.y + second.y;
			result.z = first.z + second.z;

			return result;
		}

		public static OverRaveClass operator - (OverRaveClass first, OverRaveClass second)
		{
			OverRaveClass result = new OverRaveClass();

			result.x = first.x - second.x;
			result.y = first.y - second.y;
			result.z = first.z - second.z;

			return result;
		}

		public static OverRaveClass operator - (OverRaveClass one)
		{
			OverRaveClass result = new OverRaveClass();

			result.x = - one.x;
			result.y = - one.y;
			result.z = - one.z;

			return result;
		}

		public static OverRaveClass operator ++(OverRaveClass one)
		{
			OverRaveClass result = new OverRaveClass();

			result.x = one.x + 1;
			result.y = one.y + 1;
			result.z = one.z + 1;

			return result;
		}

		public void Show()
		{
			Console.WriteLine("x:{0}, y:{1}, z:{2}", x, y, z);
		}
	}
}
