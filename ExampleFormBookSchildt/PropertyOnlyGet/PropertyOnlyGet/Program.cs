using System;
using PropertyOnlyGet.FolderForClass;

namespace PropertyOnlyGet
{
	class Program
	{ // This program show how work Propery in class
		static void Main(string[] args)
		{
			UseProperty obj = new UseProperty(22);

			int num;

			var ran = new Random();

			for (int i = 0; i < obj.Length; i++)
			{
				obj[i] = i * ran.Next(10, 55); // set elements to array
			}

			Console.Write("Array: [ ");
			for (int i = 0; i < obj.Length; i++)
			{
				num = obj[i]; // use indexer
				Console.Write("{0}, ", num);
			}
			Console.Write("]");

			Console.WriteLine("Lement witn ndex 5 have value: {0}", obj[5]); // use indexer
			Console.WriteLine("Array have length: {0} (amount elements)", obj.Length); // use property

			// obj.Length = 10; - we can't set size array because property have only get method
			Console.ReadLine();
			
		}
	}
}
