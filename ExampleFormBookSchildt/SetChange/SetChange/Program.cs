using System;

namespace SetChange
{
	class Program
	{
		static int Main(string[] args)
		{
			if (args.Length < 2)
			{
				Console.WriteLine("Set text for show how work this progrma!");

				return 1;
			}

			if (args[0] != "set" & args[0] != "get")
			{
				Console.WriteLine("first enter set or get then enter text!");

				return 1;
			}

			for (int n = 1; n < args.Length; n++)
			{
				for (int i = 0; i < args[n].Length; i++)
				{
					if (args[0] == "set")
					{
						Console.Write((char)(args[n][i] + 1));
					}
					else
					{
						Console.Write((char)(args[n][i] - 1));
					}
				}
				Console.Write(" ");
			}
			Console.WriteLine();
			return 0;
		}
	}
}
