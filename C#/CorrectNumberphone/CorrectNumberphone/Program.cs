using System;

namespace CorrectNumberphone
{
	class Program
	{ // "(123) 456-7890" - true
		public bool CheckDigit (char [] inArrayChar)
		{
			if (Char.IsDigit(inArrayChar[1]) && Char.IsDigit(inArrayChar[2]) && Char.IsDigit(inArrayChar[3]) && Char.IsDigit(inArrayChar[6]) && Char.IsDigit(inArrayChar[7])
						&& Char.IsDigit(inArrayChar[8]) && Char.IsDigit(inArrayChar[10]) && Char.IsDigit(inArrayChar[11]) && Char.IsDigit(inArrayChar[12]) && Char.IsDigit(inArrayChar[13]))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool PhoneNumber(string number)
		{
			bool ans = false;
			char[] arrayChar = number.ToCharArray();
			if (arrayChar.Length == 14 && arrayChar[0] == '(' && arrayChar[4] == ')' && arrayChar[5] == ' ' && arrayChar[9] == '-')
			{
				ans = true;
			}
			else
			{
				ans = false;
			}
			return ans;
		} 

		static void Main(string[] args)
		{
			Program prog = new Program();
			Console.WriteLine("{0}", prog.PhoneNumber("(123) 456-7890"));

			Console.ReadLine();
		}
	}
}
