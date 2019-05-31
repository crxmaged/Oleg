using System;
using System.Text.RegularExpressions;

namespace CamelCase
{
	class Program
	{ // most terable code
		public static string ToCamelCase(string str)
		{
			string newStr = null, camelCase = null;
			//str.ToLower();
			string[] stringArray = str.Split('-', '_', ' ', ',', ':', '*', '%', '+', '=', '`', '&', '^', '>', '<', '/', '#');

			string[] elementOfarrayUP = new string[stringArray.Length], elementOfarrayLow = new string[stringArray.Length];

			for (int i = 0; i < stringArray.Length; i++)
			{
				elementOfarrayUP[i] = stringArray[i].ToUpper();
				elementOfarrayLow[i] = stringArray[i].ToLower();
				var charArray = stringArray[i].ToCharArray();
				var charArreyUp = elementOfarrayUP[i].ToCharArray();
				var charArreyLow = elementOfarrayLow[i].ToCharArray();
        
				for (int n = 0; n < charArreyUp.Length; n++)
				{
					if (i == 0)
					{
						charArreyLow[0] = charArray[0];
					}
					else
					{
						charArreyLow[0] = charArreyUp[0];
					}
				}
				newStr = new string(charArreyLow);
				stringArray[i] = newStr;
				camelCase = camelCase + string.Join("", newStr);
			}
			return camelCase;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(ToCamelCase("The_stealth_warrior"));
			Console.ReadKey();
		}
	}
}
