using System;

namespace ReadKey
{
	class Program
	{ // page 440
		static void Main(string[] args)
		{
			ConsoleKeyInfo presskey;

			Console.WriteLine("Press several key please! End key must: 'Q' - upper case");

			do
			{
				presskey = Console.ReadKey();
				Console.WriteLine(" You press key: {0}", presskey.KeyChar);
				if ((ConsoleModifiers.Alt & presskey.Modifiers) != 0)
				{ // If press any key not Alt, this expresion came back '0'
					Console.WriteLine("Press key 'Alt'");
				}
				if ((ConsoleModifiers.Control & presskey.Modifiers) != 0)
				{
					Console.WriteLine("Press key 'Cntl'");
				}
				if ((ConsoleModifiers.Shift & presskey.Modifiers) != 0)
				{
					Console.WriteLine("Press key 'Shift'");
				}

			} while (presskey.KeyChar != 'Q');
			 // Q mean quit
			// Console.ReadLine();
		}
	}
}
