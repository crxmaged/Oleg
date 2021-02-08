using System;

namespace ObjectArray
{
	class Program
	{ // page 372
		static void Main(string[] args)
		{ // show what accept array type object
			object[] commonArray = new object[12];

			for (int i  = 0; i < commonArray.Length/3; i++)
			{
				commonArray[i] = i * i;
			}

			for (int i = commonArray.Length/3; i < commonArray.Length/1.5; i++)
			{
				commonArray[i] = (double)i / 2;
			}

			for(int i = (int)(commonArray.Length/1.5); i < commonArray.Length; i++)
			{
				commonArray[i] = "element # " + (i + 1);
			}
			Console.Write("Array have: ");

			for(int i = 0;  i < commonArray.Length; i++)
			{
				Console.Write("{0}; ", commonArray[i]);
			}

			Console.ReadLine();
		}
	}
}
