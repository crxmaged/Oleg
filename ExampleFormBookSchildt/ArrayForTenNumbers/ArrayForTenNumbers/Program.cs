using System;

namespace ArrayForTenNumbers
{
	class Program
	{ // simple example work with array
		static void Main(string[] args)
		{
			int[] intArray = new int[10]; // array

			for (int i = 0; i < intArray.Length; i++)
			{
				intArray[i] = i + 1; // cycle to add elements to array
			}

			foreach (int element in intArray)
			{
				Console.Write("number: " + element + " "); // write to console all elements array
			}
			Console.ReadLine();
		}
	}
}
