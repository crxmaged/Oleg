using System;
using System.Collections.Generic;

namespace SoloLearnFindSimilar
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words =
			{
				"home",
				"programming",
				"victory",
				"C#",
				"football",
				"sport",
				"book",
				"learn",
				"dream",
				"fun",
			};

			int count = 0;
			string letter = Console.ReadLine();
			string[] sLetter;
			char[] Aletters;
			List<string> IList = new List<string>();

			for(int i = 0; i < words.Length; i++)
			{
				Aletters = words[i].ToCharArray();
				for (int k = 0; k < Aletters.Length; k++)
				{
					sLetter = new string[Aletters.Length];
					sLetter[k] = Aletters[k].ToString();
					if (letter == sLetter[k])
					{
						IList.Add(words[i]);
						break;
					}
				}
			}
			if (IList.Count == 0)
			{
				Console.WriteLine("No match");
			}
			else
			{
				foreach (var word in IList)
				{
					Console.WriteLine("{0}", word);
				}
			}
			Console.ReadLine();
		}
	}
}
