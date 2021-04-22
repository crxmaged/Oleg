using System;
using ExceptionVariable.Folder;

namespace ExceptionVariable
{
	class Program
	{ // page 419
		static void Main(string[] args)
		{ // Program shows what methods have Exception class 
			try
			{
				GenException.OutOfRangeException();
			}
			catch (IndexOutOfRangeException exc)
			{
				Console.WriteLine();
				Console.WriteLine("Messages about exception: ");
				Console.WriteLine(exc); // exc - call ToString method for write to console default message
				Console.WriteLine("Property StacTrace: {0} - stack exception appear", exc.StackTrace);
				Console.WriteLine("Property Message: {0} - characher of exception", exc.Message);
				Console.WriteLine("Property TargetSite: {0} - object of exception", exc.StackTrace);
			}
			Console.ReadLine();
		}
	}
}
