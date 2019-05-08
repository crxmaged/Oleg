using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countletter
{
	class Program
	{
		public static string High(string s)
		{
			int firstText = 0, maxValue;
			string vocabulary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
			char[] alphabet = vocabulary.ToCharArray();
		
			string[] strArray = s.Split(' ');
			int[] intArray = new int [strArray.Length];
			for (int count = 0; count < strArray.Length; count++)
			{
				firstText = 0;
				char[] chrArray = strArray[count].ToCharArray();
				for (int i = 0; i < chrArray.Length; i++)
				{
					for (int n = 0; n < alphabet.Length; n++)
					{
						if (chrArray[i] == alphabet[n])
						{
							firstText += Array.IndexOf(alphabet, alphabet[n]);
						}
					}
				}
				intArray[count] = firstText;
 			}
			 maxValue = intArray.Max();
			return strArray[Array.IndexOf(intArray, maxValue)].ToString();
		}

		static void Main(string[] args)
		{
			Console.WriteLine(" {0} ", High("gohknjfmpwpgk zgegzofokhj"));

			Console.ReadKey();
		}
	}
}
