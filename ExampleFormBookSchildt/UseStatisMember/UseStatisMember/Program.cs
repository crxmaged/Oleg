using System;
using UseStatisMember;

namespace UseStatisMember
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Show how work static member in the simple class: {0}", ClassWithStaticMembers.intField);

			Console.WriteLine("We can change static member of class without creat object!!!");
			Console.WriteLine("Set new value of field, we set value: 10! field intField = {0}", ClassWithStaticMembers.intField = 10);

			Console.WriteLine("Also we can use static Method of class! For example call method 'Addition'");
			Console.WriteLine("Where we change value field intField and have value: {0}", ClassWithStaticMembers.Addition());
			Console.ReadLine();
		}
	}
}
