using System;
using ProtectedAcess.ClassFolder;

namespace ProtectedAcess
{
	class Program // page 336
	{ // THis prorgram shows how we use protected in base class 
		static void Main(string[] args)
		{
			DescendantClass OBject = new DescendantClass();
			// set values
			OBject.Set(10, 22);
			// use Show method from BaseClass to see what we have
			OBject.Show();
			// use multiple method
			OBject.Multiple();
			// use method ShowResult to see result
			Console.Write("After use method multiple we have result: ");
			OBject.ShowResult();

			// pause
			Console.ReadKey();
		}
	}
}
