using System;

namespace CreatFabricMethodTypeStatic.FolderClass
{
	class ClassWithFabricMethodStatic
	{
		int n, m;

		public static ClassWithFabricMethodStatic FabricMethod (int i, int k)
		{
			ClassWithFabricMethodStatic newObj = new ClassWithFabricMethodStatic();
			newObj.n = i;
			newObj.m = k;

			return newObj;
		}

		public void Show()
		{
			Console.WriteLine("First value is: {0}, second value is: {1}", n, m);
		}
	}
}
