using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoMinOfArray
{
	public static class Kata
	{
		public static int sumTwoSmallestNumbers(int[] numbers)
		{
			int temp = 0, sum = 0;
			int[] array = numbers;
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] > array[j])
					{
						temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
			return sum = array[0] +array[1];
			}
		}

		class Program
	{
		static void Main(string[] args)
		{
			int[] num = {5, 6, 22, 10, 0};
			Console.WriteLine(Kata.sumTwoSmallestNumbers(num));
			Console.ReadLine();
		}
	}
}
