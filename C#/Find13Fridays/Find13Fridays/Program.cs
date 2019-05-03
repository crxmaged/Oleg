using System;


namespace Find13Fridays
{
	class Program
	{
		public static int UnluckyDays(int year)
		{
			int count = 0;
			if (year.ToString().Length == 4)
			{
				for (int i = 1; i <= 12; i++)
				{
					DateTime findDate = new DateTime(year, i, 13);
					{
						if (findDate.DayOfWeek == DayOfWeek.Friday)
						{
							count = count + 1;
						}
					}
				}
			}
			else
			{
				for (int i = 1; i <= 12; i++)
				{
					DateTime findDate = new DateTime(DateTime.Now.Year, i, 13);
					{
						if (findDate.DayOfWeek == DayOfWeek.Friday)
						{
							count = count + 1;
						}
					}
				}
			}
			return count;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(UnluckyDays(2015));

			Console.ReadLine();
		}
	}
}
