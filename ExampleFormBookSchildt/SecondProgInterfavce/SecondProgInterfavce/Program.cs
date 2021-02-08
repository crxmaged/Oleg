using System;
using SecondProgInterfavce.Folder;

namespace SecondProgInterfavce
{
	class Program
	{
		static void Main(string[] args)
		{ // page 379
			Console.WriteLine("Press any key to Start program!");
			Console.ReadKey();

			ClassReliseInterface Step = new ClassReliseInterface();

			Console.WriteLine("Step one: {0}", Step.GoStep());
			Console.WriteLine("Step two: {0}", Step.GoStep());
			Console.WriteLine("Step three: {0}", Step.GoStep());
			Console.WriteLine("Step four: {0}", Step.GoStep());

			Step.Reset();
			Console.WriteLine("Now use method reset and after write to console what have: {0}", Step.GoStep());

			Console.WriteLine("Set first point! For example 10!");
			Step.SetFirstStep(10);

			Console.WriteLine("Now first step is: {0}", Step.GoStep());

			Console.WriteLine("Previous step is {0}", Step.GetPreviousValue());

			Console.WriteLine("______________________________________________");
			Console.WriteLine("Anothe method shows prime value: ");
			AnotherRealizeInterfacecs StepPrime = new AnotherRealizeInterfacecs();
			Console.WriteLine("Step one: {0}", StepPrime.GoStep());
			Console.WriteLine("Step two: {0}", StepPrime.GoStep());
			Console.WriteLine("Step three: {0}", StepPrime.GoStep());
			Console.WriteLine("Step four: {0}", StepPrime.GoStep());
			Console.WriteLine("End of program)");

			Console.ReadKey();
		}
	}
}
