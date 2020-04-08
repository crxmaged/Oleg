using System;
using AlmostSimpleExample.FolderWithClass;

namespace AlmostSimpleExample
{
	class Program
	{
		static void Main(string[] args)
		{
			BitFour FirstObj = new BitFour(11);
			BitFour SecondObj = new BitFour(22);
			BitFour ThirdObj = new BitFour();
			int i;

			Console.WriteLine("First object have: {0}", (int) FirstObj);
			Console.WriteLine("Second object have: {0}", (int) SecondObj);

			if (FirstObj < SecondObj)
			{
				Console.WriteLine("First object smaller than Second object!");
			}

			ThirdObj = FirstObj + SecondObj;

			Console.WriteLine("Third object have value: {0}", (int) ThirdObj);
			FirstObj += 5;

			Console.WriteLine("Afte First object additon 5 value, object have new value and it is: {0}", (int) FirstObj);
			Console.WriteLine();

			i = FirstObj * 2 + 3;
			Console.WriteLine("variable 'i' after done expresion: FirstObj * 2 + 3,  have value: {0}", i);
			Console.WriteLine();

			Console.WriteLine("We can use cycle!");

			for (FirstObj = 0; FirstObj < 10; FirstObj++)
			{
				Console.WriteLine("First object have value {0}", (int) FirstObj);
			}

			Console.ReadLine();
		}
	}
}
