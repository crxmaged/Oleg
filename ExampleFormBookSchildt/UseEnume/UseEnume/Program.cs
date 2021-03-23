using System;

namespace UseEnume
{
	class Program
	{ // page 397
		enum Apple { Jonathan, GoldenDel, RedDel, Winesap, Cortland, McIntosh };

		static void Main(string[] args)
		{ // simple example how can use enum
			Console.WriteLine("Apple 'RedDel' have count number: {0}", (int)Apple.RedDel);

			string[] colorApple =
			{
				"red",
				"yellow",
				"dark-red",
				"light-red",
				"purple-red",
				"red-green"
			};

			Apple i; // great variable enum type Apple
			// Now use i variable for cycle for)))
			// and use members of enum
			for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
			{
				Console.WriteLine("Sort apple {0} have value {1} in enum 'Apple'", i, (int)i);

				Console.WriteLine();
			}

			// enum Apple and array colorApple have same size 
			// show what sort of apples have a color
			// for this we use cycle of enum
			for(i = Apple.Jonathan; i <= Apple.McIntosh; i++)
			{
				Console.WriteLine("Apple sort {0}, have cololr {1}", i, colorApple[(int)i]);
			}

			Console.ReadLine();
		}
	}
}
