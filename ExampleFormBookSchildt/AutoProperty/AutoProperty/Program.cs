using System;
using AutoProperty.SomeFolder;

namespace AutoProperty
{ // page 323
	class Program
	{
		static void Main(string[] args)
		{ // Use autoProperty Lenght and CheckError
			UseAutoProperty ObjArray = new UseAutoProperty(12);
			Console.Write("[ ");
			for (int i = 0; i < ObjArray.Lenght + 1; i++)
			{
				ObjArray[i] = 10 * i; // use indexer to set value of array members
				Console.Write(" {0};", ObjArray[i]);
				if (i == ObjArray.Lenght) // use property 
				{
					Console.Write(" ]");
				}
				if (ObjArray.CheckError)
				{
					Console.WriteLine();
					Console.WriteLine("Error! Last member of array is over flow of array");
				}
			}
			Console.ReadLine();
		}
	}
}
