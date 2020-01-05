using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDuringOverloadMethod.Methods
{
	class DifferentMetodsWithSameName
	{ // Shows how compiler choose what type prefer during overlad methods
		public void Method (int n)
		{
			Console.WriteLine("Value {0} have type integer!", n);
		}

		public void Method (double n)
		{
			Console.WriteLine("Value {0} have type double!", n);
		}
	}
}
