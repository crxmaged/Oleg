using System;
using InheritanceInterfaceAnotherInterface.Folder;

namespace InheritanceInterfaceAnotherInterface
{
	class Program
	{ // page 387
		static void Main(string[] args)
		{
			ClassAB MyObject = new ClassAB();

			MyObject.FirstMethod();
			MyObject.SecondMethod();
			MyObject.ThirdMethod();

			Console.ReadLine();
		}
	}
}
