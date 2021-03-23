using System;

namespace UseTryCatch
{
	class Program
	{ // page 406
		static void Main(string[] args)
		{ // Use try/catch block
			int[] array = new int[4]; // array have 4 members

			try
			{ // if don't have exception in block try, catch block don't work
				Console.WriteLine("Show how work excepion in C#");
				// try to out of array range
				Console.Write("Array have members:");
				for (int i = 0; i < array.Length + 5; i++) // bigest then length of array
				{
					array[i] = (i * i);
					Console.Write("{0}, ", array[i]); // exception
				}
				Console.WriteLine("Not show! If exist exception");
			}
			catch(IndexOutOfRangeException)
			{
				Console.WriteLine();
				Console.WriteLine("Out of range array");
			}
			Console.WriteLine("Program continue, after try/catch block");
			// same code try/catch but without OUTOFRAGE faulse
			try
			{
				Console.WriteLine("Show how work excepion in C#");
				// try to out of array range
				Console.Write("Array have members:");
				for (int i = 0; i < array.Length; i++) // normal length
				{
					array[i] = (i * i);
					Console.Write("{0}, ", array[i]);
				}
				Console.WriteLine();
				Console.WriteLine("Not show! If exist exception \n or show do not have exception");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine();
				Console.WriteLine("Out of range array");
			}

			Console.ReadLine();
		}
	}
}
