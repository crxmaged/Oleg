using System;

namespace OverloadAndOrNot
{
	class Program
	{
		static void Main(string[] args)
		{
			ClassForOver Point_A = new ClassForOver(1, 2 , 3);
			ClassForOver Point_B = new ClassForOver(10, 10, 10);
			ClassForOver Point_C = new ClassForOver(0, 0, 0);

			Console.WriteLine("Now we have three Points with coordinats!");
			Console.Write("Point_A has:");
			Point_A.Show();
			Console.Write("Point_B has:");
			Point_B.Show();
			Console.Write("Point_C has:");
			Point_C.Show();

			if (!Point_A) Console.WriteLine("Point_A has coordinats with zero value!");
			if (!Point_B) Console.WriteLine("Point_B has coordinats with zero value!");
			if (!Point_C) Console.WriteLine("Point_C has coordinats with zero value!");

			if (Point_A & Point_B)
			{
				Console.WriteLine("Points A and B without zero coordinats!");
			}
			else
			{
				Console.WriteLine("Points A and B have zero coordinats!");
			}

			if (Point_A & Point_C)
			{
				Console.WriteLine("Points A and C without zero coordinats!");
			}
			else
			{
				Console.WriteLine("Points A and C have zero coordinats!");
			}

			if (Point_A | Point_B)
			{
				Console.WriteLine("Points A or B without zero coordinats!");
			}
			else
			{
				Console.WriteLine("Points A and Point B have all zero coordinats!");
			}

			if (Point_A | Point_C)
			{
				Console.WriteLine("Points A or C without zero coordinats!");
			}
			else
			{
				Console.WriteLine("Points A and Point C have all zero coordinats!");
			}

			Console.ReadLine();
		}
	}
}
