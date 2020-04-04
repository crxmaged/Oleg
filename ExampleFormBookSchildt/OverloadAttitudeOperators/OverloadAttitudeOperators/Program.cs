using System;
using OverloadAttitudeOperators.OhCommon;

namespace OverloadAttitudeOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			UsersOperators Point_A = new UsersOperators(2, 4, 2);
			UsersOperators Point_B = new UsersOperators(10, 5, 1);
			UsersOperators Point_C = new UsersOperators(7, 3, 2);
			UsersOperators Point_D = new UsersOperators(4, 2, 2);

			Console.Write("Point A have coordinats: ");
			Point_A.Show();
			Console.Write("Point B have coordinats: ");
			Point_B.Show();
			Console.Write("Point C have coordinats: ");
			Point_C.Show();
			Console.Write("Point D have coordinats: ");
			Point_D.Show();

			if (Point_A > Point_C)
			{
				Console.WriteLine("Point A have bigger distance than Point C");
			}
			if (Point_A < Point_C)
			{
				Console.WriteLine("Point A have low distance than Point C");
			}
			if (Point_A > Point_B)
			{
				Console.WriteLine("Point A have long distance than Point B");
			}
			if (Point_A < Point_B)
			{
				Console.WriteLine("Point A have low distance than Point B");
			}

			if (Point_A > Point_D)
			{
				Console.WriteLine("Point A have longest distance than Point D");
			}
			else if (Point_A < Point_D)
			{
				Console.WriteLine("Point A have low distance than Point D");
			}
			else
			{
				Console.WriteLine("Point A and Point D have same distance than");
			}

			Console.ReadLine();
		}
	}
}
