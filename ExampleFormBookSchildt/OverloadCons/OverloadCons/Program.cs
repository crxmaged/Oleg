using System;
using OverloadCons.Common;

namespace OverloadCons
{
	class Program
	{
		static void Main(string[] args)
		{
			OvrConstClass e1 = new OvrConstClass();

			OvrConstClass e2 = new OvrConstClass(100);

			OvrConstClass e3 = new OvrConstClass(5.7);

			OvrConstClass e4 = new OvrConstClass(123, 321);

			Console.WriteLine("Contructor with one parametr type int {0}", e2.xl);
			Console.WriteLine("Contructor with one parametr type double {0}", e3.xl);
			Console.WriteLine("Contructor with two parametrs type int {0}", e4.xl);

			Console.ReadLine();
		}
	}
}
