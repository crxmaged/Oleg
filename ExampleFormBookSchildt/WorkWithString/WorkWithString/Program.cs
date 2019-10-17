
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

			Console.WriteLine("Appear str1 appart symbol");
			for (int i = 0; i < str1.Length; i ++)
			{
				Console.Write(str1[i] + " ");
			}
			Console.WriteLine("\n");

			if (str1 == str2) Console.WriteLine("str1 == str2");
			else Console.WriteLine("str1 != str2");
			if (str1 == str3) Console.WriteLine("str1 == str3");
			else Console.WriteLine("str1 != str3");

			result = string.Compare(str3, str1, StringComparison.CurrentCulture);
			if (result == 0) Console.WriteLine("size of string str1 and string str3 are equal");
			else if (result < 0) Console.WriteLine("size string str1 < string str3");
			else Console.WriteLine("size string str1 < string str3");

			str2 = "One Two Three One";

			idx = str2.IndexOf("One", StringComparison.Ordinal);
			Console.WriteLine("First index of word One in text {0}", idx);

			Console.ReadLine();
		}
	}
}
