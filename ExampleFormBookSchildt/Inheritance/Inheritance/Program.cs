using System;
using Inheritance.ClassFolder;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Student StudentOne = new Student { FirstName = "Bob", LastName = "Dylan" };

			StudentOne.PrintName();
			StudentOne.Learn();

			People persone = new Student { FirstName = "John", LastName = "Smith" };
			// persone.Learn();

			// try to use method Learn anothe way

			Student StudentTwo = new Student { FirstName = "Mark", LastName = "Tsukerberg" };
			StudentTwo.Learn();

			PrintFullname(StudentTwo);

			Console.ReadLine();
		}

		public static void PrintFullname( People persone )
		{
			Console.WriteLine("Persone have surname: {0} and name: {1}", persone.LastName, persone.FirstName);
		}
	}
}
