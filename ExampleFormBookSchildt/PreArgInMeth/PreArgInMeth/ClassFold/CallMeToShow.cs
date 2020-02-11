using System;

namespace PreArgInMeth.ClassFold
{
	class CallMeToShow
	{
		public static void ShowText (string str, int start = 0, int stop = -1)
		{
			if (stop < 0) stop = str.Length;

			if (stop > str.Length | start > stop | start < 0) return; // end method

			for (int i = start; i < stop; i++)
			{
				Console.Write(str[i]); 
			}
			Console.WriteLine();
		}
	}
}
