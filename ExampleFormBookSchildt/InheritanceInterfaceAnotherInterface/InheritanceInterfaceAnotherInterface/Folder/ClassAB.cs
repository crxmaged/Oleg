using System;

namespace InheritanceInterfaceAnotherInterface.Folder
{
	class ClassAB : IComponentB
	{
		public void FirstMethod()
		{
			Console.WriteLine("Execution First method from interface IComponentA");
		}

		public void SecondMethod()
		{
			Console.WriteLine("Execution Second method from interface IComponentB");
		}

		public void ThirdMethod()
		{
			Console.WriteLine("Execution Third method from interface IComponentB");
		}
	}
}
