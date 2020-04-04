using System;
using OverloadBool.CommonFiles;

namespace OverloadBool
{
	class Program
	{
		static void Main(string[] args)
		{
			YesOrNo Point_A = new YesOrNo(12, 14, 16);
			YesOrNo Point_B = new YesOrNo(5, 5, 5);
			YesOrNo Point_C = new YesOrNo(0, 0, 0);

			Console.Write("Fisrt point have: ");
			Point_A.SHow();
			Console.Write("Second point have: ");
			Point_B.SHow();
			Console.Write("THird point have: ");
			Point_C.SHow();

			if (Point_A) Console.WriteLine("First point have at least one of coordinats not zero");
			else Console.WriteLine("First point have zero coordinats!");
			if (Point_B) Console.WriteLine("Second point have at least one of coordinats not zero");
			else Console.WriteLine("Second point have zero coordinats!");
			if (Point_C) Console.WriteLine("Third point have at least one of coordinats not zero");
			else Console.WriteLine("THird point have zero coordinats!");

			// alternative circle

			do
			{
				Console.Write("Second change coodrinats: ");
				Point_B.SHow();
				Point_B--;
			}
			while (Point_B);

			Console.ReadLine();
		}
	}
}
