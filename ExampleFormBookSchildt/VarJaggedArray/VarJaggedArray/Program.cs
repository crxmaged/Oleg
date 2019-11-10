using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarJaggedArray
{
	class Program
	{ // Example array (jagged) with var elements
		static void Main(string[] args)
		{
			var jagged = new[] { new[] { 1, 2, 3, 4 }, new[] { 9, 8, 7 }, new[] { 11, 12, 13, 14, 15 } };
			for (int j = 0; j < jagged.Length; ++j) // jagged.Length = 3
			{
				for (int i = 0; i < jagged[j].Length; i++) // jagged[0].Length = 4, jagged[1].Length = 3, jagged[2].Length = 5
				{
					Console.Write("{0} ", jagged[j][i]);
				}
				Console.WriteLine("|");
			}
			Console.ReadLine();
		}
	}
}
