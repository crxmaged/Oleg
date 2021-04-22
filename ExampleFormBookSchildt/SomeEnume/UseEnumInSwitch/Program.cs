using System;

namespace UseEnumInSwitch
{
	class Program
	{ // use simple enum
		enum Years
		{ 
			Spring,
			Summer,
			Autumn,
			Winter
		}

		static void Main(string[] args)
		{
			Years year = Years.Summer;
			try
			{ // read use set and compare with enum values
				Console.WriteLine("Type season of the year");
				string text = Console.ReadLine();
				year = (Years)Enum.Parse(typeof(Years), text, ignoreCase: true);
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Incorrect typing :(");
			}
			switch (year)
			{ // use switch with enum
				case Years.Spring:
					Console.WriteLine("You typed Spring");
					break;
				case Years.Summer:
					Console.WriteLine("You typed Summer");
					break;
				case Years.Autumn:
					Console.WriteLine("You typed Autumn");
					break;
				case Years.Winter:
					Console.WriteLine("You typed Winter");
					break;
				default:
					Console.WriteLine("Incorrect typing :(");
					break;
			}

			// puase:
			Console.ReadLine();
		}
	}
}
