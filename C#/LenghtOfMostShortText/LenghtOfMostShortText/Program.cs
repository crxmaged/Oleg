using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenghtOfMostShortText
{
	class Program
	{ // Find shorters word of the text and return length this word 
		public static int FindShort(string s) 
		{
			if (s.Length != 0 || s != null || s !="") // check text exist
			{
				string str = s;
				string[] subString = str.Split(' '); // text to array
				
				List<string> SortedWords = subString.ToList<string>(); // array to List
				SortedWords.Sort((x, y) => x.Length.CompareTo(y.Length)); // Sort List, first element most shorters
				return SortedWords[0].Length; // return length first element of list
			}
			else
			{
				return 0;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FindShort("pointed out, your original code doesn't exactly do what you're trying to accomplish"));

			Console.ReadKey();
		}
	}
}
