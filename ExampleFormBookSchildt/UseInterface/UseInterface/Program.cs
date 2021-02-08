using System;
using UseInterface.CommonFolder;

namespace UseInterface
{
	class Program
	{ // page 
		static void Main(string[] args)
		{
			ByTwos Sample = new ByTwos();

			Console.Write("Next number is:");
			for (int i = 0; i < 10; i++)
			{
				Console.Write(" {0};", Sample.GetNext());
			}
			Console.WriteLine();
			Console.WriteLine("Now reset all number, and try again!");

			Sample.Reset();
			Console.Write("Next number is:");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(" {0};", Sample.GetNext());
			}
			Console.WriteLine();
			Console.WriteLine("Set start point of count!");
			Sample.SetStartPoint(22);

			Console.Write("Fist point is 22 and we have count: ");
			Console.Write("Next number is:");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(" {0};", Sample.GetNext());
			}

			Console.ReadKey();
		}
	}
}
