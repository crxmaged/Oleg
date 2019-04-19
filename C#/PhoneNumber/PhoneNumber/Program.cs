using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
	public class Program
	{
		public static string CreatePhoneNumber(int[] numbers)
		{
			string str;
			string resString = string.Join("", numbers);
			char[] getNum = resString.ToCharArray();
			char[] phoneArray = new char [numbers.Length + 4];
			if (numbers.Length == 10)
			{
				for (int i = 0; i < phoneArray.Length; i++)
				{
					switch (i)
					{
						case 0:	phoneArray[i] = '('; break;
						case 1: phoneArray[i] = getNum[i - 1]; break;
						case 2: phoneArray[i] = getNum[i - 1]; break;
						case 3: phoneArray[i] = getNum[i - 1]; break;
						case 4: phoneArray[i] = ')'; break;
						case 5: phoneArray[i] = ' '; break;
						case 6: phoneArray[i] = getNum[i - 3]; break;
						case 7: phoneArray[i] = getNum[i - 3]; break;
						case 8: phoneArray[i] = getNum[i - 3]; break;
						case 9: phoneArray[i] = '-'; break;
						case 10: phoneArray[i] = getNum[i - 4]; break;
						case 11: phoneArray[i] = getNum[i - 4]; break;
						case 12: phoneArray[i] = getNum[i - 4]; break;
						case 13: phoneArray[i] = getNum[i - 4]; break;
					}
				}
				str = string.Join("", phoneArray);
			}
			else
			{
				str = "(000) 000-0000";
			}
			return str;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(CreatePhoneNumber(new int [] {1,2,3,4,5,6,7,8,9,0}));

			Console.ReadLine();
		}
	}
}
