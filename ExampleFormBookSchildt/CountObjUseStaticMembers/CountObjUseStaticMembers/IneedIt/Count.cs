using System;

namespace CountObjUseStaticMembers.IneedIt
{
	class Count
	{
		static int count = 0;

		public Count()
		{
			count++;
		}
		~Count()
		{
			count--;
		}
		public static int GetCount()
		{
			return count;
		}
	}
}
