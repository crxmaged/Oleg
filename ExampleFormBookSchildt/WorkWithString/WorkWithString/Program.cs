
using System;
using System.Globalization;

namespace WorkWithString
{
	class Program
	{
		static void Main(string[] args)
		{
			string str1 = "Use C# language!";
			string str2 = "Use C# language!";
			string str3 = "Strings in C# laguage very uselufe!";

			string strUp, strLow;

			int result, idx;

			Console.WriteLine("{0}", str1);
			Console.WriteLine("Length first text is: {0}", str1.Length);

			strLow = str1.ToLower(CultureInfo.CurrentCulture);
			strUp = str1.ToUpper(CultureInfo.CurrentCulture);

			Console.WriteLine("Lower reg variant {0}", strLow);
			Console.WriteLine("Upper reg variant {0}", strUp);
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
