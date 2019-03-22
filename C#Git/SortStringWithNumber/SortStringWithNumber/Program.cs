using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SortStringWithNumber
{
	public static class Kata
	{
		public static string Order(string words)
		{
			if (words == null || words.All(c => c.Equals('_') || c.Equals('-') || c.Equals('>') || c.Equals('<')) )
			{
				return string.Empty;
			}
			else
			{
				int temp;
				string returnString = "", tempString;
				string[] array = words.Split(' ');
				int[] intNumber = new int[array.Length];

				for (int i = 0; i < array.Length; i++)
				{
					intNumber[i] = Int32.Parse(Regex.Match(array[i], @"\d+").Value);
				}

				for (int i = 0; i < intNumber.Length - 1; i++)
				{
					for (int j = i + 1; j < intNumber.Length; j++)
					{
						if (intNumber[i] > intNumber[j])
						{
							temp = intNumber[i];
							intNumber[i] = intNumber[j];
							intNumber[j] = temp;

							tempString = array[i];
							array[i] = array[j];
							array[j] = tempString;
						}
					}
				}
				returnString = string.Join(" ", array);

				return returnString;
			}
		}
	}

	class Program
	{ 
		static void Main(string[] args)
		{
			Console.WriteLine(Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
			Console.ReadKey();
		}
	}
}
