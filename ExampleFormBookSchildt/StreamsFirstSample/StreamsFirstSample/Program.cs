using System;

namespace StreamsFirstSample
{
	class Program
	{
		static void Main(string[] args)
		{
			char ch = ' ';
			string text;
			Console.WriteLine("Hello!!! \nWrite text Hello too, then push button 'Enter'");
			text =  Console.In.ReadLine();
			Console.WriteLine("You enter! {0}", text);
			while (text.ToUpper() != "HELLO")
			{
				Console.WriteLine("Please try again!");
				text = Console.In.ReadLine();
			}
			Console.WriteLine("Good work! Now you can write any text! \n Write: ");
			string str = Console.ReadLine();
			Console.WriteLine("Thank you! Now press any key! Then push button 'Enter'");
			ch = (char)Console.Read();
			Console.WriteLine("You push key: '{0}' and write text: '{1}'", ch, str);
			// Pausse
			Console.ReadKey();
		}
	}
}
