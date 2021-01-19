using System;

namespace ValueTypeVsReferenceType
{
	class Program
	{ // This program show difference value type and reference type
		// Simple examples: 
		static void Method (int value)
		{
			value = 10;
			// try to change value for variable 'a'
		}

		static void Method(int [] value)
		{
			for (int i = 0; i < value.Length; i++)
			{
				value[i] = value[i] * 2; 
			}
			// try to change value for array 'b'
		}

		static void Main(string[] args)
		{
			// variable 'a' is value type 
			int a = 10;
			Console.WriteLine("Now variable 'a' (value type) equal: {0}", a);

			Method(a);
			Console.WriteLine("After call Method variable 'a' equal: {0}", a);
			Console.WriteLine();
			// variable 'b' is reference type
			int[] b = new int [] { 1, 3, 5, 7, 9};

			Console.WriteLine("We have array 'b' (referance type) equal: ");
			foreach(int s in b)
			{
				Console.Write(s + "; ");
			}

			Method(b);
			Console.WriteLine("After call Method array 'b' equal: ");
			foreach (int s in b)
			{
				Console.Write(s + "; ");
			}
			Console.WriteLine();

			Console.WriteLine("This program shows difference work value type and referance type");

			Console.ReadKey();
		}
	}
}
