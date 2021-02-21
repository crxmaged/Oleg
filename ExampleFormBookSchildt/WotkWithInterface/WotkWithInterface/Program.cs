using System;
using WotkWithInterface.CommonFolder;

namespace WotkWithInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			TwoNumberscs TwoObject = new TwoNumberscs();
			PrimeNumbers PrimeObject = new PrimeNumbers();
			CommonInterface GeneralObject;

			Console.WriteLine("First count!");
			for (int i = 0; i < 5; i++)
			{
				GeneralObject = TwoObject;
				Console.WriteLine("Step {0} equale: {1}", i, GeneralObject.GoStep());
			}

			Console.WriteLine("Anothe count");

			for (int i = 0; i < 5; i++)
			{
				GeneralObject = PrimeObject;
				Console.WriteLine("Step {0} equale: {1}", i, GeneralObject.GoStep());
			}

			Console.ReadLine();
		}
	}
}
