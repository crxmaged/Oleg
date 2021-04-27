using System;
using UseExtentionMethod.Folder;

namespace UseExtentionMethod
{
	class Program
	{
		static void Main(string[] args)
		{ // this progrma shows how can use exctesion method
			DateTime cuttentTime = DateTime.Now;
			cuttentTime.PrintTime();
			if (cuttentTime.WeekDay(DateTime.Now.DayOfWeek))
			{
				Console.WriteLine("Weekend :)");
			}
			else
			{
				Console.WriteLine("I can't wait of weekend :(");
			}

			Console.ReadLine();
		}
	}
}
