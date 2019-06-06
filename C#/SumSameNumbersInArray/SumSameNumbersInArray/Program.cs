using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSameNumbersInArray
{
	class Program
	{
		public static List<int> SumConsecutives(List<int> s)
		{
			List<int> finalyList = s; // take array
			List<int> newList = new List<int>(); // creat array for finaly answer
			int firstNumber, secondNumber, newElement = 0, countSum = 1; // variable

			for (int i = 0; i < finalyList.Count; i++) // one cycle for count same element
			{
				firstNumber = finalyList[i]; // take first element of array
				if (i < finalyList.Count - 1) // check for overload array
				{
					secondNumber = finalyList[i + 1]; // take next element of array
					if (firstNumber == secondNumber) // check of same element
					{
						newElement = firstNumber; // use this variable for take sum same element 
						++countSum; // amount iterations same elements of array 
					}
					else
					{
						if (countSum > 1) // end sum of same elements
						{
							newElement = newElement * countSum; // 
							newList.Add(newElement);
							countSum = 1;
						}
						else
						{
							newList.Add(firstNumber);
						}
					}
				}
				else
				{
					newList.Add(firstNumber);
				}
			}
			return newList;
		}

		static void Main(string[] args)
		{
			SumConsecutives(new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 }).ForEach(Console.WriteLine);
			Console.ReadLine();
		}
	}
}
