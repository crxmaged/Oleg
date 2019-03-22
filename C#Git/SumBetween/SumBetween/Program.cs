using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBetween
{
	public class Sum
	{
		/*
		public int GetSum(int a, int b)
		{
			int sum = 0;
			if (a < b)
			{
				for (int x = a; x <= b; x++)
				{
					sum += x;
				}
			}
			else if (a > b)
			{
				for (int x = b; x <= a; x++)
				{
					sum += x;
				}
			}
			else
			{
				Console.WriteLine("{0} Since both are same", a);
			}
			return sum;
		}
		*/
		public int GetSum(int a, int b)
		{
			int sum = 0;
			if (a != b)
			{
				if (a < b)
				{
					for (int x = a; x <= b; x++)
					{
						sum += x;
					}
				}
				else
				{
					for (int x = b; x <= a; x++)
					{
						sum += x;
					}
				}
			}
			else
			{
				Console.WriteLine("{0} Since both are same", a);
			}
				return sum;
			}
		}

	class Program
	{

		static void Main(string[] args)
		{
			Sum sum = new Sum();
			Console.WriteLine("{0}", sum.GetSum(-5, -5));

			Console.ReadKey();
		}
	}
}
