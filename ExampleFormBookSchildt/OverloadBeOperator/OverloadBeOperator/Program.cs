using System;
using OverloadBeOperator.CommonFolder;

namespace OverloadBeOperator
{
	class Program
	{
		static void Main(string[] args)
		{ // set coordinat!
			NewActiviteForOperator firstCoordinat = new NewActiviteForOperator(1, 2, 3);
			NewActiviteForOperator secondCoordinat = new NewActiviteForOperator(10, 11, 12);
			NewActiviteForOperator thirthCoordinat = new NewActiviteForOperator();

			Console.Write("We have coordinat for point one: ");
			firstCoordinat.ShowCurrentValue();

			Console.Write("And coordinat for point two: ");
			secondCoordinat.ShowCurrentValue();

			Console.Write("We set new coodinat for point three! And it's: ");
			thirthCoordinat = firstCoordinat + secondCoordinat;
			thirthCoordinat.ShowCurrentValue();
			Console.WriteLine();

			Console.Write("Another coordinat: ");
			thirthCoordinat = thirthCoordinat + firstCoordinat + secondCoordinat;
			thirthCoordinat.ShowCurrentValue();
			Console.WriteLine();

			Console.Write("Little change!");
			thirthCoordinat = thirthCoordinat - secondCoordinat;
			thirthCoordinat.ShowCurrentValue();
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
