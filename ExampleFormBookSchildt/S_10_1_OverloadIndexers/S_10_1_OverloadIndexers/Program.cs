using System;
using S_10_1_OverloadIndexers.Folder_With_Class;

namespace S_10_1_OverloadIndexers
{
	class Program
	{
		static void Main(string[] args)
		{
			WorkWithIndexers ArrayObj = new WorkWithIndexers(13); // creat array 13 length
			Random random = new Random();
			// set value to array
			for (int i = 0; i < ArrayObj.length; i++)
			{
				ArrayObj[i] = random.Next(333, 444);
			}

			ArrayObj[3] = 199; // set int index
			ArrayObj[3.6] = 333; // set double index

			Console.WriteLine(ArrayObj[3]); // show value array
			Console.WriteLine(ArrayObj[3.7]); // show value array
			// Show all elements of array
			Console.WriteLine("All array elements");
			// Show all elements off array
			for (int i = 0; i < ArrayObj.length; i++)
			{
				Console.Write(ArrayObj[i] + "; ");
			}

			Console.ReadLine();
		}
	}
}
