using System;
using OverloadOperInt.ClassForOverload;

namespace OverloadOperInt
{
	class Program
	{
		static void Main(string[] args)
		{
			Points Point_A = new Points(10, 100, 1000);
			Points Point_B = new Points(-100, 0, 100);
			Points Point_C = new Points();
			int i;

			Console.Write("Point A have ");
			Point_A.Show();
			Console.Write("Point B have ");
			Point_B.Show();
			Console.Write("Point C have ");
			Point_C.Show();

			Console.WriteLine();

			Point_C = Point_A + Point_B;
			Console.Write("New coordinat for Point C");
			Point_C.Show();

			Console.WriteLine("Now we explicit object (users) type to int!");
			i = Point_A; // implicit to type int
			Console.WriteLine("Explicit from type with coordinat to int, and we have result: {0}", i);

			Console.WriteLine("Try to count this formula Point A * 2 - Point B {0}", Point_A*2-Point_B);

			Console.ReadLine();
		}
	}
}
