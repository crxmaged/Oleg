using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAlphabet
{
	class Program
	{

		/* ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz
		 * NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm*/

		static void Main(string[] args)
		{

		}

		public static string Rot13(string input)
		{
			char[] array = input.ToCharArray();
			char[] arraySecond = new char[array.Length];
			int[] indexArray = new int[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				indexArray[i] = (int)array[i];
				if (indexArray[i] <= 77)
				{
					indexArray[i] = indexArray[i] + 13;
				}
				else if (indexArray[i] >= 110)
				{
					indexArray[i] = indexArray[i] - 13;
				}
				else if (indexArray[i] >= 78 && indexArray[i] <= 90)
				{
					indexArray[i] = indexArray[i] - 13;
				}
				else if (indexArray[i] >= 97 && indexArray[i] <= 109)
				{
					indexArray[i] = indexArray[i] + 13;
				}
			}

			for (int n = 0; n < array.Length; n++)
			{
				arraySecond[n] = (char)indexArray[n];
			}

			string s = new string(arraySecond);
			return s;
		}
	}
}
