using System;

namespace UseCatchs
{ // Use two or more catch in one try
	class Program
	{ // page 411
		static void Main(string[] args)
		{ // creat arrays
			int[] arrayNumber = { 4, 8, 16, 32, 64, 128, 256, 512 };
			int[] arrayCheck = { 2, 0, 4, 4, 0, 8 };

			for (int i = 0; i < arrayNumber.Length; i++)
			{
				try
				{
					Console.WriteLine(arrayNumber[i] + " / " + arrayCheck[i] + " = " + arrayNumber[i]/arrayCheck[i]);
				}
				catch (DivideByZeroException) // if try divided to zero
				{
					Console.WriteLine("Can't divided to zero '0' !!!");
				}
				catch (IndexOutOfRangeException) // if index out of current array
				{
					Console.WriteLine("That array too small. So index out of range this array...");
				}
			}

			Console.ReadLine();
		}
	}
}
