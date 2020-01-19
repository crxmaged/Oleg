using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotNecessaryArg.FolderWIthOneClass
{
	class NecessaryArgInMeth
	{
		public static void CallTheMehod(int age, int id = 100000001, string name = "No set perosnal name")
		{
			Console.WriteLine("Age person: {0}",  age);
			Console.WriteLine("Id person: {0}", id);
			Console.WriteLine("Name person: {0}", name);
		}
	}
}
