using System;
using UseThisInConstructor.Folder;

namespace UseThisInConstructor
{
	class Program
	{
		static void Main(string[] args)
		{
			// Call different constructor
			UseThis newObj1 = new UseThis();
			UseThis newObj2 = new UseThis(10, 11);
			UseThis newObj3 = new UseThis(newObj2);

			Console.ReadLine();
		}
	}
}
