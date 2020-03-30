using System;
using StaticClass.FolderWIthStaticClass;

namespace StaticClass
{
	class Program
	{ // Use static class with static members
		static void Main(string[] args)
		{
			Console.WriteLine("Fract of number 4.44 is {0}", StaticClassWithStaticMethod.LookFractPartOfNumber(4.44));
			Console.WriteLine("Is the number 7 odd? ans: {0}", StaticClassWithStaticMethod.LookOddNumber(7));
			Console.WriteLine("Replicant of number 5 is {0}", StaticClassWithStaticMethod.Replic(5));
			Console.WriteLine("Is the number 8 even? ans: {0}", StaticClassWithStaticMethod.LookEvenNumber(8));

			Console.ReadLine();
		}
	}
}
