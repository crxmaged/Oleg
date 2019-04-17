using System;

namespace CutFirstAndLastCharacterInString
{
	class Program
	{ // Cut First and Last Character in Input String
		public string CutSring (string str)
		{
			if (str.Length > 1)
			{
				char[] stringArray = str.ToCharArray();
				char[] newArray = new char[str.Length - 2];
				for (int i = 0; i < newArray.Length; i++)
				{
					newArray[i] = stringArray[i+1];
				}
				str = new string(newArray);
				return str;
			}
			else
			{
				return "";
			}
		}

		static void Main(string[] args)
		{
			Program test = new Program();
			Console.WriteLine(test.CutSring(""));
			
			Console.ReadLine();
		}
	}
}
