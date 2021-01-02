using System;
using Share.ShowInheritance;

namespace Share
{
	class Program
	{
		static void Main(string[] args)
		{
			SonClass firstExam = new SonClass();
			SonClass secondExam = new SonClass();
			SonClassPlus thirdExam = new SonClassPlus();

			firstExam.Width = 5.5;
			firstExam.Height = 5.5;
			firstExam.sTyle = "equal";

			secondExam.Width = 8.0;
			secondExam.Height = 12.0;
			secondExam.sTyle = "with 90 corner";

			Console.WriteLine("First figure informarion!");
			firstExam.ShowStyle();
			firstExam.ShowSize();
			Console.WriteLine("Squer of figure is: {0}", firstExam.Area());

			Console.WriteLine();

			Console.WriteLine("Second figure informarion!");
			secondExam.ShowStyle();
			secondExam.ShowSize();
			Console.WriteLine("Squer of figure is: {0}", secondExam.Area());
			Console.WriteLine();
			// Use anothe sonClass 
			thirdExam.Height = 10;
			thirdExam.Width = 10;
			if(thirdExam.IsSuare())
			{
				Console.WriteLine("We have square with the same size of height and width");
			}

			// We can use father class apart of sonclass! For example:
			Console.WriteLine("Finaly we use only father class with his unit");
			FatherClass anotheExam = new FatherClass();
			anotheExam.Height = 10;
			anotheExam.Width = 20;

			anotheExam.ShowSize();
			Console.WriteLine();
			Console.WriteLine("Press any key to exit!");

			Console.ReadLine();
		}
	}
}
