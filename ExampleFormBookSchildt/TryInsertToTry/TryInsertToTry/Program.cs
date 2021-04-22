using System;

namespace TryInsertToTry
{
	class Program
	{ // page 413
		static void Main(string[] args)
		{
			int[] arrayOne = {100, 120, 50, 300, 22, 150, 900, 999 };
			int[] arrayTwo = { 2, 4, 10, 0, 3, 0 };

			try // outer try
			{ // important fault
				for (int i = 0; i < arrayOne.Length; i++)
				{
					try // inner try - nest Try
					{ // less important fault
						Console.WriteLine("{0} / {1} = {2}", arrayOne[i], arrayTwo[i], arrayOne[i]/arrayTwo[i]);
					}
					catch (DivideByZeroException)
					{
						Console.WriteLine("Not allow divited to zero number!");
					}
				}
			}

			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Out of array");
				Console.WriteLine("Program stoped!");
			}

			Console.ReadLine();
		}
	}
}
