using System;
using Indexer.FolderWIthClass;

namespace Indexer
{
	class Program
	{
		static void Main(string[] args)
		{ // creat new object with array
			ClassWithArrayUseIndexer UseArray = new ClassWithArrayUseIndexer(10);

			int x; // get value from array

			Console.WriteLine("First we set incorrect index!");
			for (int i = 0; i < (UseArray.Length * 2); i++)
			{
				UseArray[i] = i * 10; // we use indexer and try to set value
			}
			// get correct index, incorrect index we can't see because we have check for overload
			for (int i = 0; i < (UseArray.Length * 2); i++)
			{
				x = UseArray[i]; // use indexer and tru to get value
				if (x != -1)
				{
					if(UseArray.Check)
					{
						Console.WriteLine();
						Console.Write("Index out of range array! ");
					}
					Console.Write("x: {0}; ", x);
				}
			}

			Console.WriteLine();

			Console.WriteLine("Show incorrect index!");
			for (int i = 0; i < (UseArray.Length * 2); i++)
			{
				UseArray[i] = i * 10; // we use indexer and try to set value
				if (UseArray.Check)
				{
					Console.WriteLine("We try SET indext that out of range array");
				}
			}
			// get correct index, incorrect index we can't see because we have check for overload
			for (int i = 0; i < (UseArray.Length * 2); i++)
			{
				x = UseArray[i]; // use indexer and tru to get value
				if (!UseArray.Check)
				{
					Console.Write("x: {0}; ", x);
				}
				else
				{
					Console.WriteLine();
					Console.Write("We try GET indext that out of range array /n");
				}
			}

			Console.ReadLine();
		}
	}
}
