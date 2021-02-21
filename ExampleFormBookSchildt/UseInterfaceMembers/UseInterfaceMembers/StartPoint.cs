using System;
using UseInterfaceMembers.Folder;

namespace UseInterfaceMembers
{
	class StartPoint
	{ // page 390
		static void Main(string[] args)
		{
			UserClass MyObject = new UserClass();

			Console.WriteLine("Use method 'Method' from first interface");
			Console.WriteLine("Method take one parameter (number 3) afte return one result: {0}", MyObject.Method_A(3));

			Console.WriteLine("Use method 'Method' from second interface");
			Console.WriteLine("Method take one parameter (number 3) afte return one result: {0}", MyObject.Method_B(3));

			Console.ReadLine();
		}
	}
}
