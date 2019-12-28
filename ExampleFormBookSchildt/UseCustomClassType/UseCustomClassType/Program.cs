using System;
using UseCustomClassType.MyClassTypes;

namespace UseCustomClassType
{
	class Program
	{ // use objcet in the same class UseCustomClassType
		static void Main(string[] args) // whre method Factor return UseCustomClassType type object
		{
			UseThisClass obj1 = new UseThisClass(4, 5);

			Console.Write("Size rect : ");
			obj1.Show();
			Console.WriteLine("Area rect: {0}", obj1.Area());
			Console.WriteLine("Do rect little biger! Use method 'Factor' to 4 size!");

			UseThisClass obj2 = obj1.Factor(4);
			Console.WriteLine("Now we have new rect with size Area!!!");
			Console.WriteLine("Area rect: {0}", obj1.Area());
			Console.ReadLine();
		}
	}
}
