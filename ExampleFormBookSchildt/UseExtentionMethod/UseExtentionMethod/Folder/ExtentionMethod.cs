using System;

namespace UseExtentionMethod.Folder
{
	static class ExtentionMethod
	{
		public static void PrintTime(this DateTime dateTime)
		{
			Console.WriteLine("{0}", dateTime);
		}

		public static bool WeekDay(this DateTime dateTime, DayOfWeek week)
		{
			return DayOfWeek.Saturday == week || DayOfWeek.Sunday == week;
		}
	}
}
