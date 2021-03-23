using System;

namespace AnotheUseTryCatch
{
	class Program
	{ // page 410
		static void Main(string[] args)
		{ // show anothe exception in C#
			int[] arrayOne = { 10, 12, 8, 44, 3, 9 };
			int[] arrayTwo = { 1, 2, 0, 10, 0, 9 };

			if (arrayOne.Length == arrayTwo.Length)
			{
				for (int i = 0; i < arrayOne.Length; i++)
				{
					try
					{
						Console.WriteLine("{0} / {1} = {2}", arrayOne[i], arrayTwo[i], (arrayOne[i]/arrayTwo[i]));
					}
					catch (DivideByZeroException)
					{
						Console.Write("{0} / {1} = ", arrayOne[i], arrayTwo[i]);
						Console.Write("Can't divide!!!");
						Console.WriteLine();
					}
				}
			}

			Console.ReadLine();
		}
	}
}
