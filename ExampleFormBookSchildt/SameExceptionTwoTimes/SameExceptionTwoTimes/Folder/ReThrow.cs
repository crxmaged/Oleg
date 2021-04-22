using System;

namespace SameExceptionTwoTimes.Folder
{
	class ReThrow
	{
		public static void GenException ()
		{
			int[] arrayOne = { 102, 50, 22, 34, 12, 888, 404 };
			int[] arrayTwo = { 2, 0, 11, 10, 0, 1 };

			for (int i = 0; i < arrayOne.Length; i++)
			{
				try
				{
					Console.WriteLine("Result: {0}/{1} = {2}", arrayOne[i], arrayTwo[i], arrayOne[i]/arrayTwo[i]);

				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Try divide to Zero! - Exception");
				}
				catch (IndexOutOfRangeException)
				{
					Console.WriteLine("Index out of array!!!");
					throw; // ReException another method from Program class
				}
			}
		}
	}
}
