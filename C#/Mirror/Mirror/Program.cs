using System;

namespace Mirror
{
	class Program
	{
		public int ReverseNumber(int n)
		{
			char[] digits = null;
			char[] firstNum = null;
			char thx;
			string s;
			if (n < 0)
			{
				n = n * (-1);
				digits = n.ToString().ToCharArray();
				firstNum = digits;
				for (int i = 0; i < digits.Length / 2; i++)
				{
					for (int k = digits.Length - 1 - i; k == digits.Length - 1 - i; k--)
					{
						thx = digits[i];
						digits[i] = firstNum[k];
						digits[k] = thx;
					}
				}
				s = new string(digits);
				n = Int32.Parse(s);
				return n * (-1);
			}
			else
			{
				digits = n.ToString().ToCharArray();
				firstNum = digits;
				for (int i = 0; i < digits.Length / 2; i++)
				{
					for (int k = digits.Length - 1 - i; k == digits.Length - 1 - i; k--)
					{
						thx = digits[i];
						digits[i] = firstNum[k];
						digits[k] = thx;
					}
				}
				s = new string(digits);
				n = Int32.Parse(s);
				return n;
			}
		}

		// return int.Parse(String.Join("", Math.Abs(n).ToString().Reverse())) * (n < 0 ? -1 : 1);

		static void Main(string[] args)
		{
			Program newEx = new Program();

			Console.WriteLine("{0}", newEx.ReverseNumber(-12345678));

			Console.ReadKey();
		}
	}
}
