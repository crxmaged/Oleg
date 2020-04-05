using System;

namespace OverloadAndOrNot
{
	class ClassForOver
	{
		int x, y, z;

		public ClassForOver()
		{
			x = y = z = 0;
		}

		public ClassForOver(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static bool operator | (ClassForOver opLeft, ClassForOver opRight)
		{
			if (((opLeft.x != 0) || (opLeft.y != 0) ||(opLeft.z != 0)) | ((opRight.x != 0) || (opRight.y != 0) || (opRight.z != 0)))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool operator &(ClassForOver opLeft, ClassForOver opRight)
		{
			if (((opLeft.x != 0) && (opLeft.y != 0) && (opLeft.z != 0)) & ((opRight.x != 0) && (opRight.y != 0) && (opRight.z != 0)))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool operator ! (ClassForOver OneOperand)
		{
			if ((OneOperand.x != 0) || (OneOperand.y != 0) || (OneOperand.z != 0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public void Show ()
		{
			Console.WriteLine("Coordinats x:{0}, y:{1}, z:{2}", x, y, z);
		}
	}
}
