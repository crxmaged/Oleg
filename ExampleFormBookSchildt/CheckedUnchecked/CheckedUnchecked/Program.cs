using System;

namespace CheckedUnchecked
{
	class Program
	{ // page 429
		static void Main(string[] args)
		{ // use operator checked/unchecked
			byte a, b;
			byte result;

			a = 127;
			b = 127;

			try
			{
				result = unchecked((byte)(a * b));
				Console.WriteLine("Use operator unchecked but know that have overflow, result is: {0}", result);
				result = checked((byte)(a * b));
				Console.WriteLine("_____________________________________");
				Console.WriteLine("Use operator checked anothe way of overflow, result is: {0}", result);
			}
			catch (OverflowException exc)
			{
				Console.WriteLine("Exception: {0}", exc);
			}
			Console.ReadLine();
		}
	}
}
