using System;
using CreatFabricMethodTypeStatic.FolderClass;

namespace CreatFabricMethodTypeStatic
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int num1 = 0, num2 = 10;  num1 < 10; num1++, num2--)
			{
				ClassWithFabricMethodStatic newObj = ClassWithFabricMethodStatic.FabricMethod(num1, num2);

				newObj.Show();
			}

			Console.ReadLine();
		}
	}
}
