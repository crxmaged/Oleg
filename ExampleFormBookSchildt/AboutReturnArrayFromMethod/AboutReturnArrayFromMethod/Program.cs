using System;
using AboutReturnArrayFromMethod.FolderWithClasses;

namespace AboutReturnArrayFromMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			ShowHowMethodReturnArray fact = new ShowHowMethodReturnArray(); // assinged object
			int sizeNum = 1000;
			int amountFactors; // name say all about what have this value;
			int[] facts = fact.Factor(sizeNum, out amountFactors); // use Methof of object 'fact'

			Console.WriteLine("Factors of number {0}:", sizeNum);

			for (int i = 0; i < amountFactors; i++)
			{ // Show all factors elemts 
				Console.Write(facts[i] + " "); 
			}

			Console.ReadLine();
		}
	}
}
