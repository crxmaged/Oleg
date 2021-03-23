using System;

namespace UniversalCatch
{
	class Program
	{ // page 412
		static void Main(string[] args)
		{ // use universale catch, not usefull but still work)
			int[] arrayOne = { 10, 200, 350, 55, 10, 1000, 11 };
			int[] arrayTwo = { 2, 0, 5, 4, 0, 0 };

			for (int i = 0; i < arrayOne.Length; i++)
			{
				try
				{
					Console.WriteLine("Step {0} element {1} from first array divided '/' element {2} from second array! {1}/{2}={3}", i+1, arrayOne[i], arrayTwo[i], (arrayOne[i] / arrayTwo[i]));
				}
				catch
				{
					Console.WriteLine("Same exception...");
				}
			}

			Console.ReadLine();
		}
	}
}
