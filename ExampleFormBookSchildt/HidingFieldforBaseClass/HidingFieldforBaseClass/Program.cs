using System;
using HidingFieldforBaseClass.CommonFolder;

namespace HidingFieldforBaseClass
{
	class Program
	{ // page 344
		static void Main(string[] args)
		{
			InheritanceClass @object = new InheritanceClass(33);

			Console.WriteLine("Show what we have in Inheritance class!");
			@object.Show();

			Console.WriteLine("What we have in base class:");
			@object.ShowBase();

			Console.ReadLine();
		}
	}
}
