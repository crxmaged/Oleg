using System;
using TryCatchFinally.Folder;

namespace TryCatchFinally
{
	class Program
	{ // page 418
		static void Main(string[] args)
		{
			for(int i = 0; i < 3; i++)
			{
				Console.WriteLine("Try set value {0} to param in method Exception!", i);
				CheckExceptions.Exceptio(i);
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
