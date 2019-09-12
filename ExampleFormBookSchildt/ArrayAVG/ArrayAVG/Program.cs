using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAVG
{
	class Program
	{
		static void Main(string[] args)
		{ // Enter size array! After program creat array, add random number to array
			Console.WriteLine("Enter size array!"); // And count average number of array
			bool res = true;
			int sizeArray;
			Random rand = new Random();
			do
			{
				if (res != true)
				{
					Console.WriteLine("Try againe!");
				}
				res = Int32.TryParse(Console.ReadLine(), out sizeArray);
			} while (res == false);
			int[] arrayNumber = new int[sizeArray];
			for (int i = 0; i < sizeArray; i++)
			{
				arrayNumber[i] = rand.Next(1, 100);
			}
			Console.WriteLine("Now we have array: ");
			foreach (int resNum in arrayNumber)
			{
				Console.Write(", {0}", resNum);
			}
			Console.WriteLine();
			int avg = 0;
			for (int n = 0; n < arrayNumber.Length; n++)
			{
				avg = avg + arrayNumber[n];
			}
			if (avg != 0)
			{
				Console.WriteLine("Average number of array is: {0}", avg / arrayNumber.Length);
			}
			Console.ReadLine();
		}
	}
}
