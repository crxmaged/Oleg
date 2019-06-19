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
			Console.WriteLine(Rot13(" While the company has won all of its previous cases, Sillesen foreign " +
				"companies from doing business in Ukraine."));

			Console.ReadLine();
		}

		public static string Rot13(string input) // method change text to ROT13 decoder
		{
			char[] array = input.ToCharArray(); // conver sting to char array
			char[] arraySecond = new char[array.Length]; // creat array to covert after decode and return string
			int[] indexArray = new int[array.Length]; // convert char array to interger array

			for (int i = 0; i < array.Length; i++) // use cycle for change (decod) elements in array
			{
				indexArray[i] = (int)array[i];
				if (indexArray[i] <= 77 && indexArray[i] >= 65)
				{
					indexArray[i] = indexArray[i] + 13;
				}
				else if (indexArray[i] >= 110 && indexArray[i] <= 122)
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

			for (int n = 0; n < array.Length; n++) // return from int array to char array
			{
				arraySecond[n] = (char)indexArray[n];
			}

			string s = new string(arraySecond); // convert char array to srting
			return s; // result
		}
	}
}
