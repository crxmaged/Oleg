using System;
using SameExceptionTwoTimes.Folder;

namespace SameExceptionTwoTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ReThrow.GenException();
			}
			catch (IndexOutOfRangeException)
			{
				// Use 'throw' from class ReThrow - ReException
				Console.WriteLine("ReCall IndexOutOfRangeException in 'Main' method - program stoped :( \n This catch in main method of program, out of the class: ReThrow");
			}

			Console.ReadLine();
		}
	}
}
