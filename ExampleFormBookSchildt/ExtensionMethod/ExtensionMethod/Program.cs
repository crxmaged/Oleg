using System;
using ExtensionMethod.Folder;

namespace ExtensionMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Persion persion = new Persion { FirstName = "Albert", LastName = "Anderson" };

			persion.ShowFullName();

			Console.ReadLine();
 		}
	}
}
