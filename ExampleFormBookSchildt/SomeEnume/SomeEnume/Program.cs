using System;

namespace SomeEnume
{
	class Program
	{
		enum WeekDays : byte // set enum that type byte 
		{ // default type of enum is integer
			Monday = 1,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		static void Main(string[] args)
		{
			WeekDays ExampleDay = WeekDays.Saturday;
			// get what type of nume
			Console.WriteLine("Type of enum is: {0}", Enum.GetUnderlyingType(typeof(WeekDays)));

			Console.Write("Day of week: {0}", ExampleDay); // show value one of member from enum WeekDay

			Console.WriteLine(". This day have number of the week {0}", (byte)ExampleDay); // same but byte type

			Console.WriteLine("Name week number 4 is {0}", (WeekDays)4); // anothe way to use 

			Console.WriteLine("What day after Thursday? It is: {0}", SetNextDay(WeekDays.Thursday));
			// use check of exception in enum
			if (Enum.IsDefined(typeof(WeekDays), (byte)8))
			{ 
				Console.WriteLine("Name week number 4 is {0}", (WeekDays)8);
			}
			else
			{
				Console.WriteLine("Uncorrect number of week!");
			}

			Console.ReadLine();
		}
		// one of the way how use enum in method
		static WeekDays SetNextDay (WeekDays day)
		{
			if (day < WeekDays.Sunday)
			{
				return day + 1;
			}
			else
			{
				return WeekDays.Monday;
			}
		}
	}
}
