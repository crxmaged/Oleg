using System;
using ExtantionMethod.Com;

namespace ExtantionMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "Test text";

			ClassWithExtantionMethod.ExMethod(text);

			text.ExMethod();

			Console.ReadKey();
		}
	}
}
