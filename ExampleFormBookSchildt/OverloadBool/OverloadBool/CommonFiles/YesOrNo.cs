using System;

namespace OverloadBool.CommonFiles
{
	class YesOrNo
	{
		int x, y, z;

		public YesOrNo ()
		{
			x = y = z = 0;
		}

		public YesOrNo (int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static bool operator true (YesOrNo opAns)
		{
			if ((opAns.x != 0) || (opAns.y != 0) || (opAns.z != 0))
			{
				return true;
			}
			else return false;
		}

		public static bool operator false(YesOrNo opAns)
		{
			if ((opAns.x == 0) && (opAns.y == 0) && (opAns.z == 0))
			{
				return true;
			}
			else return false;
		}

		public static YesOrNo operator -- (YesOrNo opMinus)
		{
			YesOrNo res = new YesOrNo();

			res.x = opMinus.x - 1;
			res.y = opMinus.y - 1;
			res.z = opMinus.z - 1;

			return res;
		}

		public void SHow ()
		{
			Console.WriteLine("Coordinats x: {0}, y: {1}, z: {2}", x , y, z);
		}
	}
}
