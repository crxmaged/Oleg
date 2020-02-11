using System;

namespace UseStatisMember
{
	class ClassWithStaticMembers
	{
		// public static! field 
		public static int intField = 1000;

		// public static Method!
		public static int Addition ()
		{
			intField = intField * 2;
			return intField;
		}
	}
}
