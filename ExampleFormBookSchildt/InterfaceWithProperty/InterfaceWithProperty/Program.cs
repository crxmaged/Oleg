using System;
using InterfaceWithProperty.CommonFolder;

namespace InterfaceWithProperty
{
	class Program
	{ // page 384s
		static void Main(string[] args)
		{
			Class StepByStep = new Class();

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("After step #{0}, number equale: {1}", i, StepByStep.NextStep -2);
			}

			Console.WriteLine("Start point is {0}", 22);

			StepByStep.NextStep = 22;
			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("Step #{0}, number equale: {1}", i, StepByStep.NextStep - 2);
			}

			Console.ReadLine();
		}
	}
}
