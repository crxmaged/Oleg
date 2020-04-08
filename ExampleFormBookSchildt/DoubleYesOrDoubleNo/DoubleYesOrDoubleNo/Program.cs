using System;
using DoubleYesOrDoubleNo.FolderForClass;

namespace DoubleYesOrDoubleNo
{
	class Program
	{
		static void Main(string[] args)
		{
			ClasWithAndOrNotTrueFalse Pont_A = new ClasWithAndOrNotTrueFalse(10, 20, 30);
			ClasWithAndOrNotTrueFalse Pont_B = new ClasWithAndOrNotTrueFalse(11, 11, 11);
			ClasWithAndOrNotTrueFalse Pont_C = new ClasWithAndOrNotTrueFalse(0, 0, 0);

			Console.Write("Point A have:");
			Pont_A.Show();
			Console.Write("Point B have:");
			Pont_B.Show();
			Console.Write("Point C have:");
			Pont_C.Show();

			if (Pont_A)
			{
				Console.WriteLine("Point A - exist!");
			}
			if (Pont_B)
			{
				Console.WriteLine("Point B - exist!");
			}
			if (Pont_C)
			{
				Console.WriteLine("Point C - exist!");
			}

			if (!Pont_A)
			{
				Console.WriteLine("Point A - not exist!");
			}
			if (!Pont_B)
			{
				Console.WriteLine("Point B - not exist!");
			}
			if (!Pont_C)
			{
				Console.WriteLine("Point C - not exist!");
			}

			Console.WriteLine();

			if (Pont_A & Pont_B)
			{
				Console.WriteLine("Point A and Point B have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point B don't have coordinats or only one!");
			}

			if (Pont_A & Pont_C)
			{
				Console.WriteLine("Point A and Point C have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point C don't have coordinats or only one!");
			}

			if (Pont_A | Pont_B)
			{
				Console.WriteLine("Point A and Point B have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point B don't have coordinats");
			}

			if (Pont_A | Pont_C)
			{
				Console.WriteLine("Point A and Point C have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point C don't have coordinats");
			}

			Console.WriteLine();

			if (Pont_A && Pont_B)
			{
				Console.WriteLine("Point A and Point B have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point B don't have coordinats or only one!");
			}

			if (Pont_A && Pont_C)
			{
				Console.WriteLine("Point A and Point C have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point C don't have coordinats or only one!");
			}

			if (Pont_A || Pont_B)
			{
				Console.WriteLine("Point A and Point B have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point B don't have coordinats");
			}

			if (Pont_A || Pont_C)
			{
				Console.WriteLine("Point A and Point C have coordinats!");
			}
			else
			{
				Console.WriteLine("Point A and Point C don't have coordinats");
			}

			Console.ReadLine();
		}
	}
}
