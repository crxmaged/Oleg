using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalNumber
{
	class Program
	{ // We find unar number of 
		static int count = 0; // count how step to get a finish number

		public static int Multiplicative(params int[] number) // get calculation sum of all numbers  
		{
			int firstNum = 1;
			for (int i = 0; i < number.Length; i++)
			{
				firstNum = firstNum * number[i]; // use simple example
			}
			return firstNum;
		}

		public static int Persistence(long n)
		{
			count = 0; // reset count for the next test from codewar
			int num; // new number after each iteration
			char[] charArr = n.ToString().ToCharArray(); // first step for convert
			int[] sequence = new int[charArr.Length]; // creat array, we use this array in Method: Multiplicative

			for (int i = 0; i < charArr.Length; i++)
			{
				sequence[i] = Convert.ToInt32(charArr[i].ToString()); // add elements to int array
			}

			int[] arrayForMul = new int[sequence.Length]; // use array after sum all elements and creat new number

			while (sequence.Length > 1) // check! Is number biggest form 0 to 9 
			{ 
				char[] stepArray = Multiplicative(sequence).ToString().ToCharArray(); // new number after sum all element old numbers
				arrayForMul = new int[stepArray.Length]; // change size of array
				for (int i = 0; i < arrayForMul.Length; i++)
				{
					arrayForMul[i] = Convert.ToInt32(stepArray[i].ToString()); // add element to array
				}
				count++; // count number of times multiply
				sequence = arrayForMul; // set new array after count 
			}

			if (Int32.TryParse(string.Join("", arrayForMul), out num)) // return final result
			{
				return count;
			}
			else
			{
				return 0; 
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Persistence(5634));

			Console.ReadLine();
		}
	}
}
 