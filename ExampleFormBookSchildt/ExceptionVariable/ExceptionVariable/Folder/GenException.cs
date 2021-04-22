using System;

namespace ExceptionVariable.Folder
{
	class GenException
	{
		public static void OutOfRangeException ()
		{ // special class with Exception
			int[] array = new int[4]; //creat array with 4 elements size
			Console.WriteLine("Creat exception!");
			// Exception out of the range in array
			Console.Write("Array have elements: { ");
			for (int i = 0; i < 10; i++) // set bigger request that array size
			{
				array[i] = i * 22;
				Console.Write("{0}", array[i]);
			}
			Console.Write("}");
			Console.WriteLine("If no exception, but we know that is't not true)))");
		}
	}
}
