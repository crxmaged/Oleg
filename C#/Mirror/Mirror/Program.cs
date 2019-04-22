using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror
{
	class Program
	{
		public int ReverseNumber(int n)
		{
			char[] digits = n.ToString().ToCharArray();
			char[] firstNum = digits;
			char thx;
			for (int i = 0; i < digits.Length/2; i++)
			{
				for (int k = digits.Length - 1 - i; k == digits.Length - 1 - i; k--)
				{
					thx = digits[i];
					digits[i] = firstNum[k];
					digits[k] = thx;
				}
			}
			string s = new string(digits);
			n = Int32.Parse(s);
			return n;
		}

		static void Main(string[] args)
		{
			Program newEx = new Program();

			Console.WriteLine("{0}", newEx.ReverseNumber(12345678));

			Console.ReadKey();
		}
	}
}
