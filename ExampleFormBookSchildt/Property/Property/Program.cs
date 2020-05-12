using System;
using Property.FolderWithClass;

namespace Property
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("In this program we use property and show how it working");

			ClassWithClass obj = new ClassWithClass();
			Console.WriteLine("First show default value field: {0}", obj.Prop);
			// Set new value
			obj.Prop = 100;
			// Show new value
			Console.WriteLine("New value for private field with checkpoint! Value: {0}", obj.Prop);

			Console.WriteLine("Try set not positive value for field! Set -100");
			obj.Prop = -100;
			Console.WriteLine("Value is: {0}", obj.Prop);

			Console.ReadLine();
		}
	}
}
