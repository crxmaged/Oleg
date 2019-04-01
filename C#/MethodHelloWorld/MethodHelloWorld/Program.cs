using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHelloWorld
{
	public static class Kata
	{
		public static string green()
		{
			string str = "hello world!";
			if (str.Length >= 8)
			{
				return str;
			}
			else
			{
				return "expected";
			}
		}
		// Write a public static method "greet" that returns "hello world!"
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Kata.green());

			Console.ReadLine();
		}
	}
}
