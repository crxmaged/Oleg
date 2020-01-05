using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDifferentMethods.FonldeWithDifferentMethods
{
	class Methods
	{
		public void OverMethod()
		{
			Console.WriteLine("Method void without param");
		} // Method void without param

		public void OverMethod(int i)
		{
			Console.WriteLine("Method void with int param i");
		} // Method void with int param i

		public int OverMethod(int i, int n)
		{
			Console.WriteLine("Method with two param and return multiplication them, type int");
			return i * n;
		} // Method with two param and return multiplication them, type int

		public double OverMethod(double i, double n)
		{
			Console.WriteLine("Method with two param and return multiplication them type double");
			return i * n;
		} // Method with two param and return multiplication them type double
	}
}
