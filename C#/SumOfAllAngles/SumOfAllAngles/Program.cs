using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllAngles
{
	class Program
	{
		public static int Angle(int n)
		{
			if (n > 180)
			{
				return (n/180)+2;
			}
			else
			{
				return 3;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Angle(360));

			Console.ReadLine();
		}
	}
}
