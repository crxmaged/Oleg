using System;

namespace OverloadAttitudeOperators.OhCommon
{
	class UsersOperators
	{
		int x, y, z;

		public UsersOperators()
		{
			x = y = z = 0;
		}

		public UsersOperators(int x, int y, int z)
		{ // set coordinat
			this.x = x;
			this.y = y;
			this.z = z;
		}
		// overload operator '<' for coordinat
		public static bool operator < (UsersOperators opLeft, UsersOperators opRight)
		{
			if ((opLeft.x*opLeft.x + opLeft.y*opLeft.y + opLeft.z*opLeft.z)<(opRight.x*opRight.x + opRight.y*opRight.y + opRight.z*opRight.z))
			{
				return true;
			}
			return false;
		}
		// overload operator '>' for coordinat
		public static bool operator > (UsersOperators opLeft, UsersOperators opRight)
		{
			if ((opLeft.x * opLeft.x + opLeft.y * opLeft.y + opLeft.z * opLeft.z) > (opRight.x * opRight.x + opRight.y * opRight.y + opRight.z * opRight.z))
			{
				return true;
			}
			return false;
		}
		// show current coordinat
		public void Show()
		{
			Console.WriteLine("coordinat x:{0}, y{1}, z{2}", x, y, z);
		}
	}
}
