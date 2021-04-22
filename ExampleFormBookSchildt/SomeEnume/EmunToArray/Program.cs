using System;

namespace EmunToArray
{
	class Program
	{
		enum Cars
		{
			Toyota,
			BMW,
			Porsche,
			Mazda,
			Chevrolet,
			Tesla
		}

		static void Main(string[] args)
		{
			var ArrayFromEnum = Enum.GetValues(typeof(Cars));

			Console.Write("{ ");
			foreach (var memberEnum in ArrayFromEnum)
			{
				Console.Write("{0}, ", memberEnum);
			}
			Console.WriteLine("}");

			Console.ReadLine();
		}
	}
}
