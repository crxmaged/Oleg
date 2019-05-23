using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllVowels
{
	class Program
	{
		public static int GetVowelCount(string str)
		{
			int vowelCount = 0;
			char[] vowel = {'a', 'e', 'i', 'o', 'u'};
			char[] text = str.ToArray();
			for (int i = 0; i < text.Length; i++)
			{
				for (int n = 0; n < vowel.Length; n++)
				{
					if (text[i] == vowel[n])
					{
						vowelCount += 1;
					}
				}
			}

			return vowelCount;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(GetVowelCount("abracadabra"));

			Console.ReadLine();
		}
	}
}
