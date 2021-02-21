using System;
using InterfaveWithPropertyAndIndexer.CommonFolder;

namespace InterfaveWithPropertyAndIndexer
{
	class Program
	{
		static void Main(string[] args)
		{ // page 385
			ClassExecuteInterface SomeObject = new ClassExecuteInterface();

			Console.WriteLine("Show count of numbers");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Step #:{0}, have number {1}", i + 1, SomeObject.GetNumber);
			}

			SomeObject.GetNumber = 22;
			Console.WriteLine("Then set point start count: {0}", SomeObject.GetNumber - 2);

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Next count number is: {0}", SomeObject.GetNumber - 2);
			}

			SomeObject.GetNumber = 0;
			Console.WriteLine("Reset all progarm!");


			Console.WriteLine("And use indexer!");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("index: {0}, have number: {1}", i, SomeObject[i]);
			}

			Console.ReadLine();
		}
	}
}
