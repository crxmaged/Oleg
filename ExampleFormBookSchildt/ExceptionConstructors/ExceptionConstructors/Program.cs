using System;
using ExceptionConstructors.Folder;

namespace ExceptionConstructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Xclass objectVal = new Xclass(22);
			Xclass secondVal = null; // non reference

			int value;
			try
			{
				value = objectVal.AddVal(secondVal); // call exception NullReferenceException
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("NullReferenceException run catch and fix this excetion :)");
				Console.WriteLine();
				// Now ragion 'catch' fix exception
				secondVal = new Xclass(44);
				value = objectVal.AddVal(secondVal);
			}
			// after fix can use method AddVal without problem
			Console.WriteLine("Value 'val' have equal: {0}", value);
			// 
			Console.ReadLine();
		}
	}
}
