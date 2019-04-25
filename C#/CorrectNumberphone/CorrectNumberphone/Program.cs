using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectNumberphone
{
	class Program
	{ // "(123) 456-7890" - true
		public bool PhoneNumber(string number)
		{
			// int n;
			bool ans = false;
			char[] arrayChar = number.ToCharArray();
			if (arrayChar.Length == 14)
			{
				if (arrayChar[0] == '(' && arrayChar[4] == ')' && arrayChar[5] == ' ' && arrayChar[9] == '-')
				{
					if (Char.IsDigit(arrayChar[1]) && Char.IsDigit(arrayChar[2]) && Char.IsDigit(arrayChar[3]) && Char.IsDigit(arrayChar[6]) && Char.IsDigit(arrayChar[7]) 
						&& Char.IsDigit(arrayChar[8]) && Char.IsDigit(arrayChar[10]) && Char.IsDigit(arrayChar[11]) && Char.IsDigit(arrayChar[12]) && Char.IsDigit(arrayChar[13]))
					{
						ans = true;
					}
				}
				/*
				for (int i = 0; i < arrayChar.Length; i++)
				{
					switch (arrayChar[i])
					{
						case '(':
							break;

					}
				}
				*/
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
