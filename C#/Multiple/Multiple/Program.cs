using System;

namespace Multiple
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = Convert.ToInt32(Console.ReadLine());

			int[] array = new int[number];
			string[] arrayCh = new string[number];
			string num = "";

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 1 + i;
				arrayCh[i] = Convert.ToString(array[i]);
				if (array[i] % 3 == 0)
				{
					arrayCh[i] = "*";
				}
			}

			for (int k = 0; k < array.Length; k++)
			{
				// Console.Write(arrayCh[k] + "; ");
				num = num + "" + arrayCh[k];
			}

			Console.WriteLine(num);
			Console.ReadKey();
		}
	}
}
