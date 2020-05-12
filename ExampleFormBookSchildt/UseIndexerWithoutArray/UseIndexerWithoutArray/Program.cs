using System;
using UseIndexerWithoutArray.FolderWithClass;

namespace UseIndexerWithoutArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Show how to work inderex without array!");
			Console.WriteLine("We set some number for count, and get ans!");

			GetAnsToTwo NewNum = new GetAnsToTwo(); // Creat example of object (instane)

			// set same number to indexer, ans show how to work my program!
			for (int i = 0; i < 8; i++)
			{ 
				Console.WriteLine("Result after counting: {0}", NewNum[i]);
			}

			Console.WriteLine("For example set incorrect value! And get ans {0} and {1}", NewNum[-1], NewNum[17]);

			Console.ReadLine();
		}
	}
}
