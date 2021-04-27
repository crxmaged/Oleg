using System;

namespace ExtensionMethod.Folder
{
	static class Extension
	{
		public static void ShowFullName(this Persion persion)
		{
			Console.WriteLine("{0} {1}", persion.FirstName, persion.LastName);
		}
	}
}
