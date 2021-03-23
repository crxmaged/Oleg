using System;

namespace InheritanceList.FolderClass
{
	class Persone
	{ // main class
		public string Name { get; set; }
		public string SurName { get; set; }

		public void ShowAllName()
		{
			Console.WriteLine("Name: {0}, surname: {1}", Name, SurName);
		}
	}
}
