using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, j;
			bool b1, b2;
			i = 10; j = 11;
			if (i < j) Console.WriteLine(" i < j");
			if (i <= j) Console.WriteLine(" i <= j");
			if (i != j) Console.WriteLine(" i != j");
			if (i == j) Console.WriteLine(" No execution ");
			if (i >= j) Console.WriteLine(" No execution ");
			if (i > j) Console.WriteLine(" No execution ");

			b1 = true; b2 = false;

			if (b1 & b2) Console.WriteLine(" No execution ");
			if (!(b1 & b2)) Console.WriteLine(" !(b1 & b2) - true ");
			if (b1 | b2) Console.WriteLine(" b1 | b2 - true ");
			if (b1 ^ b2) Console.WriteLine(" b1 ^ b2 - true ");

			Console.ReadLine();

		}
	}
}
