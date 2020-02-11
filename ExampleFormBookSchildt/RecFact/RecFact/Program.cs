using System;
using RecFact.FolderWithRec;

namespace RecFact
{
	class Program
	{
		static void Main(string[] args)
		{
			ShowRecur num = new ShowRecur();
			Console.WriteLine("Factor of number {0} is {1}", 5, num.FactR(5));
			Console.WriteLine("Factor of number {0} is {1}", 10, num.FactI(10));

			Console.ReadLine();
		}
	}
}
