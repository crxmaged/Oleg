using System;

namespace BoxingUnboxing
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 10;
			object ob;

			ob = x; // boxing

			int y = (int)ob; // unboxing

			Console.WriteLine(y);

			Console.ReadLine();

		}
	}
}
