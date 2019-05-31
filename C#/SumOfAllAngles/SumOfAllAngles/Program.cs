using System;

namespace SumOfAllAngles
{
	class Program
	{
		public static int Angle(int n)
		{
			if (n > 2)
			{
				// return (n/180)+2; // if want find number angle
				return 180*(n - 2); // if want find number total sum of angles
			}
			else
			{
				return 180;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Angle(360));

			Console.ReadLine();
		}
	}
}
