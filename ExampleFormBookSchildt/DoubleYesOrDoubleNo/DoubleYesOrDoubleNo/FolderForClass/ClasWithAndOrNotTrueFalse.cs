using System;

namespace DoubleYesOrDoubleNo.FolderForClass
{
	class ClasWithAndOrNotTrueFalse
	{ // overload operators: &&, ||, true, false, not
		int x, y, z;

		public ClasWithAndOrNotTrueFalse()
		{
			x = y = z = 0;
		}

		public ClasWithAndOrNotTrueFalse(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		#region Overload operators || and &&

		public static ClasWithAndOrNotTrueFalse operator |(ClasWithAndOrNotTrueFalse LeftSite, ClasWithAndOrNotTrueFalse RightSite)
		{
			if (((LeftSite.x != 0) || (LeftSite.y != 0) || (LeftSite.z != 0)) | ((RightSite.x != 0) || (RightSite.y != 0) || (RightSite.z != 0)))
			{
				return new ClasWithAndOrNotTrueFalse(1, 1, 1);
			}
			else
			{
				return new ClasWithAndOrNotTrueFalse(0, 0, 0);
			}
		}

		public static ClasWithAndOrNotTrueFalse operator &(ClasWithAndOrNotTrueFalse LeftSite, ClasWithAndOrNotTrueFalse RightSite)
		{
			if (((LeftSite.x != 0) && (LeftSite.y != 0) && (LeftSite.z != 0)) & ((RightSite.x != 0) && (RightSite.y != 0) && (RightSite.z != 0)))
			{
				return new ClasWithAndOrNotTrueFalse(0, 0, 0);
			}
			else
			{
				return new ClasWithAndOrNotTrueFalse(1, 1, 1);
			}
		}

		#endregion

		public static bool operator ! (ClasWithAndOrNotTrueFalse OneOperator)
		{
			if (OneOperator)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		#region Overload true/false

		public static bool operator true(ClasWithAndOrNotTrueFalse OneOperator)
		{
			if ((OneOperator.x != 0) || (OneOperator.y != 0) || (OneOperator.z != 0))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool operator false(ClasWithAndOrNotTrueFalse OneOperator)
		{
			if ((OneOperator.x == 0) && (OneOperator.y == 0) && (OneOperator.z == 0))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion

		public void Show ()
		{
			Console.WriteLine("coordinats x:{0}, y:{1}, z:{2}", x, y, z);
		}
	}
}
