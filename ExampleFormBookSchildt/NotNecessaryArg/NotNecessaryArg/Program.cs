using System;
using NotNecessaryArg.FolderWIthOneClass;

namespace NotNecessaryArg
{
	class Program
	{
		static void Main(string[] args)
		{
			// Now we call method with Original arguments
			NecessaryArgInMeth.CallTheMehod(33, 01, "Neel");
			NecessaryArgInMeth.CallTheMehod(22, 02);
			NecessaryArgInMeth.CallTheMehod(50);

			Console.ReadLine();
		}
	}
}
