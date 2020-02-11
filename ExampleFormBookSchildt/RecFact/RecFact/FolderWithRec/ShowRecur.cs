using System;


namespace RecFact.FolderWithRec
{
	class ShowRecur
	{
		public int FactR(int i)
		{
			int res;
			Console.WriteLine("Step: {0}", i);
			if (i == 1) return 1;
			res = FactR(i - 1) * i; // steps: 2(1*2), 6(2*3), 24(3*4), 120(24*5)
			Console.WriteLine("Factorial {0}! is {1}", i, res);
			return res;
		}

		public int FactI(int i)
		{
			int resultNumber = 1;
			for (int n = 1; n <= i; n++)
			{
				resultNumber = resultNumber * n;
				Console.WriteLine("Factorial number {0}! is {1}", n, resultNumber);
			}
			return resultNumber;
		}
	}
}
