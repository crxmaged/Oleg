using System;
using ShortProgram.Folder;

namespace ShortProgram
{
	class Program
	{ // page 320 
		static void Main(string[] args)
		{ // Use property and short way to set value 
			ClassWithAutoProperty exm = new ClassWithAutoProperty { Num = 11011, Text = "WTF?"};
			// Then we get value and show on console 
			Console.WriteLine("Show what have class! Text: {0} and number: {1}", exm.Text, exm.Num);

			Console.ReadLine();
		}
	}
}
