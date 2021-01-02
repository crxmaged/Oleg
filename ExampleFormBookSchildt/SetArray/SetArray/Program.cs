using System;
using SetArray.Folder;

namespace SetArray
{
	class Program
	{ // page 325 in book
		static void Main(string[] args)
		{
			WorkWithArray ObjArray = new WorkWithArray(-15, 20);
			WorkWithArray ObjNextArray = new WorkWithArray(5, 12);
			WorkWithArray ObjLastArray = new WorkWithArray(0, 22);

			Console.WriteLine("Length first array is: {0}", ObjArray.Leght);

			for (int i = ObjArray.firstPoint; i <= ObjLastArray.lastPoint; i++)
			{
				ObjArray[i] = i; // use indexer (set)
			}
			if (ObjArray.Error)
			{
				Console.WriteLine("Incorrect queru to array, please check your work!");
			}
			Console.Write("First array consist of: { ");
			for (int i = ObjArray.firstPoint; i <= ObjArray.lastPoint; i++)
			{
				Console.Write(ObjArray[i] + "; "); // use indexer (get)
			}
			Console.Write("}");
			Console.WriteLine();

			Console.WriteLine("Length second array is: {0}", ObjNextArray.Leght);

			for (int i = ObjNextArray.firstPoint; i <= ObjNextArray.lastPoint; i++)
			{
				ObjNextArray[i] = i;
			}
			if (ObjNextArray.Error)
			{
				Console.WriteLine("Incorrect queru to array, please check your work!");
			}
			Console.Write("Second array have members: { ");
			for (int i = ObjNextArray.firstPoint; i <= ObjNextArray.lastPoint; i++)
			{
				Console.Write(ObjNextArray[i] + "; ");
			}
			Console.Write("}");
			Console.WriteLine();

			Console.WriteLine("Length third array is: {0}", ObjLastArray.Leght);

			for (int i = ObjLastArray.firstPoint; i <= ObjLastArray.lastPoint; i++)
			{
				ObjLastArray[i] = i;
			}
			if (ObjLastArray.Error)
			{
				Console.WriteLine("Incorrect queru to array, please check your work!");
			}
			Console.Write("Third array have members: { ");
			for (int i = ObjLastArray.firstPoint; i <= ObjLastArray.lastPoint; i++)
			{
				Console.Write(ObjLastArray[i] + "; ");
			}
			Console.Write("}");
			Console.WriteLine();

			Console.WriteLine("DONE! Go sleep)");
			Console.ReadLine();
		}
	}
}
