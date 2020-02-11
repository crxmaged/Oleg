using System;

namespace AboutMainMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("We have: " + args.Length + " arguments");

			Console.Write("It is: ");
			for (int i = 0; i < args.Length; i++)
			{
				Console.Write(args[i] + "; ");
			}

			Console.ReadLine();
		}
	}
}
