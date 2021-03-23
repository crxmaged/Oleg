using System;

namespace Inheritance.ClassFolder
{
	class People
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public void PrintName()
		{
			Console.WriteLine("Name is {0} and surname {1}", FirstName, LastName);
		}
	}
}
