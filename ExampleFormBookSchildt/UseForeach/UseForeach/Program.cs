using System;

namespace UseForeach
{
	class Program
	{ // show how to work operator foreach! Very easy and short operator)
		static void Main(string[] args)
		{
			int sum = 0;
			int[] arrayInt = new int[10];

			for (int i = 0; i < arrayInt.Length; i++)
			{
				arrayInt[i] = i + i;
			}
			
			foreach (int ans in arrayInt)
			{
				Console.Write("{0} ", ans);
				sum = sum + ans;
			}
			Console.WriteLine();
			Console.WriteLine("The sum of all number in arrary is: {0}", sum);
			Console.ReadKey();
		}
	}
}
