using System;
using CountObjUseStaticMembers.IneedIt;

namespace CountObjUseStaticMembers
{
	class Program
	{
		static void Main(string[] args)
		{
			Count ob;

			for (int i = 0; i < 10; i++)
			{
				ob = new Count();
			}

			Console.WriteLine("We creat {0} objects!", Count.GetCount());

			Console.ReadLine();
		}
	}
}
