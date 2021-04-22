using System;
using System.Collections.Generic;

namespace SololearnSecondProgram
{
	class Program
	{
		// SoloLearn number 2
		static void Main(string[] args)
		{
			int levels = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(Points(levels));
		}

		static int Points(int levels)
		{
			int[] count = new int[levels];
			int k = 0;
			for(int i = 0; i < levels; i++)
			{
				count[i] = 1 + i;
				k = k + count[i];
			}
			Console.WriteLine(k);
			return k;
		}
	} 
}
