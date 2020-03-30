using System;
using OverBeAndUno.FolderWithClass;

namespace OverBeAndUno
{
	class Program
	{
		static void Main(string[] args)
		{
			OverRaveClass Point_A = new OverRaveClass(1, 2, 3);
			OverRaveClass Point_B = new OverRaveClass(10, 10, 20);
			OverRaveClass Point_C = new OverRaveClass();

			Console.Write("Point_A have coordinats: ");
			Point_A.Show();
			Console.WriteLine();

			Console.Write("Point_B have coordinats: ");
			Point_B.Show();
			Console.WriteLine();

			Point_C = Point_A + Point_B; // over active operator + (binar)

			Console.Write("After additon coordinats Point_A and Point_B, and set this coordinats to Point_C have coordinats: ");
			Point_C.Show();
			Console.WriteLine();

			Point_C = Point_C - Point_A; // over active operator - (binar)
			Console.WriteLine("We do Point_C = Point_C - Point_A and have! That Point_C have: ");
			Point_C.Show();
			Console.WriteLine();

			Point_C = Point_C - Point_B; // over active operator - (binar)
			Console.WriteLine("We do Point_C = Point_C - Point_B and have! That Point_C have: ");
			Point_C.Show();
			Console.WriteLine();

			Point_C = -Point_A; // over active operator - (not binar, only one!)
			Console.WriteLine("We set Point_C negative coordinats Point_A: ");
			Point_C.Show();
			Console.WriteLine();

			Point_C = Point_A++; // over active operator - (not binar, only one!)
			Console.WriteLine("We set Point_C coordinats Point_A and incrementation (Post)");
			Point_C.Show();
			Console.WriteLine();

			Console.WriteLine("Set default coordinats to Point_A!");
			Point_A = new OverRaveClass(1, 2, 3);

			Point_C = ++Point_A; // over active operator - (not binar, only one!)
			Console.WriteLine("We set Point_C coordinats Point_A and incrementation (Pref)");
			Point_C.Show();
			Console.WriteLine();

			Console.WriteLine("And show coordinats Point_A:");
			Point_A.Show();

			Console.ReadLine();
		}
	}
}
