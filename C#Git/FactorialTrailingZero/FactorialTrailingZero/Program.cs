using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZero
{
	class Program
	{
		public int Fact (int num) // How many zeroes in factorial
		{
			// long count = 0;
			string inNum = num.ToString();
			bool res = int.TryParse(inNum, out int check);
			if (res)
			{
				int FacNum = 1;

				for (int i = 1; i <= num; i++)
				{
					FacNum = FacNum * i;
				}

				Console.WriteLine("Factorial {0} is {1}", num , FacNum);

				int result = 0;
				int start = 1;
				while (num >= start)
				{
					start *= 5;
					result += (int)num / start;
				}
				return result;
			}
			else
			{
				return 0;
			}
		}

		/*
		public int Count
		{
			get { return count; }
		}
		
		static int findTrailingZeros(int n)
		{
			// Initialize result 
			int count = 0;

			// Keep dividing n by powers  
			// of 5 and update count 
			for (int i = 5; n / i >= 1; i *= 5)
				count += n / i;

			return count;
		}
		*/
			static void Main(string[] args)
		{
			Program fac = new Program();

			Console.WriteLine("Count zeroes {0}", fac.Fact(5)); // 479001600
			Console.ReadKey();
		}
	}
}
