using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNewYear
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			DateTime timeToCelebrate = new DateTime(now.Year + 1, 1, 1);
			DateTime myBirthday = new DateTime(now.Year+1, 10, 19);
			DateTime myAge = new DateTime(1987, 10, 19);

			TimeSpan leftMyBirth = myBirthday - now;
			TimeSpan left = timeToCelebrate - now;
			int age = now.Year - myAge.Year;

			Console.WriteLine("We need to wait: {0} day(s)", left.Days);
			Console.WriteLine("Lest To new year: {0} hour(s)", left.TotalHours);

			Console.WriteLine("Left to my birthday: {0} day(s). Now my age years old is: {1}", leftMyBirth.Days, age);
			Console.WriteLine("Lest To new year: {0} hour(s)", leftMyBirth.TotalHours);

			Console.WriteLine("Time to now: {0}", now);



			Console.ReadLine();
		}
	}
}
