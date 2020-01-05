using System;
using OverloadDifferentMethods.FonldeWithDifferentMethods;

namespace OverloadDifferentMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Methods meth = new Methods();

			meth.OverMethod(2);
			meth.OverMethod();
			Console.WriteLine(meth.OverMethod(3.5, 3.3));
			Console.WriteLine(meth.OverMethod(100, 11));

			Console.ReadLine();
		}
	}
}
