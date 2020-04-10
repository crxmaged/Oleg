using System;

namespace AlmostSimpleExample.FolderWithClass
{
	class BitFour
	{
		int val;

		public BitFour() // constructors
		{
			val = 0;
		}

		public BitFour(int i)
		{
			val = i;
			val = val & 0xF;
		}

		public static BitFour operator + (BitFour LeftOp, BitFour RightOp)
		{ // overload addition both arguments are object
			BitFour result = new BitFour();

			result.val = LeftOp.val + RightOp.val;
			result.val = result.val & 0xF;

			return result;
		}

		public static BitFour operator + (BitFour LeftOp, int RightOp)
		{ // overload addition arguments are object and int
			BitFour result = new BitFour();

			result.val = LeftOp.val + RightOp;
			result.val = result.val & 0xF;

			return result;
		}

		public static BitFour operator + (int LeftOp, BitFour RightOp)
		{ // overload addition arguments are int and object
			BitFour result = new BitFour();

			result.val = LeftOp + RightOp.val;
			result.val = result.val & 0xF;

			return result;
		}

		public static BitFour operator ++ (BitFour OneOp)
		{ // overload increment
			BitFour result = new BitFour();

			result.val = OneOp.val + 1;
			result.val = result.val & 0xF;

			return result;
		}

		public static bool operator > (BitFour LeftOp, BitFour RightOp)
		{ // overload > both arguments are object
			if (LeftOp.val > RightOp.val)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool operator < (BitFour LeftOp, BitFour RightOp)
		{ // overload < both arguments are object
			if (LeftOp.val < RightOp.val)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static implicit operator int (BitFour OnewOp)
		{ // implicit from object to int 
			return OnewOp.val;
		}

		public static implicit operator BitFour(int OneArg)
		{ // implicit from int to object 
			return new BitFour (OneArg);
		}
	}
}
