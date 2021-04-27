using System;

namespace TryCatchCheckedUnchecked
{
	class Program
	{ // page 430
		static void Main(string[] args)
		{
			byte a, b;
			byte result;

			a = 127;
			b = 127;

			try
			{
				unchecked
				{
					a = 127;
					b = 127;
					result = unchecked((byte)(a*b));
					Console.WriteLine("Unchecked block of code, result is: {0}", result);

					a = 125;
					b = 5;
					result = unchecked((byte)(a * b));
					Console.WriteLine("Unchecked block of code, result is: {0}", result);
				}
				checked
				{
					a = 2;
					b = 7;
					result = checked((byte)(a * b));
					Console.WriteLine("Checked block of code, result is: {0}", result);
			// all string of code will work, only after 36 number string call exception 
					a = 127;
					b = 127;
					result = checked((byte)(a * b));
					Console.WriteLine("Checked block of code, result is: {0}", result);
				}
			}
			catch (OverflowException exc)
			{
				Console.WriteLine(exc);
			}

			Console.ReadLine();
		}
	}
}
