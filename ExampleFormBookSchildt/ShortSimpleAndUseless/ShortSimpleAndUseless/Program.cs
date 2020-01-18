using System;
using ShortSimpleAndUseless.FoldWithFileClass;

namespace ShortSimpleAndUseless
{
	class Program
	{ // Show short way to set, get, use properties from anothe class
		static void Main(string[] args)
		{
			Fast newPes = new Fast() { Age = 32, Name = "Oleh" };
			Console.WriteLine("My name is : {0} and age is: {1}", newPes.Name, newPes.Age);
			Console.ReadLine();
		}
	}
}
