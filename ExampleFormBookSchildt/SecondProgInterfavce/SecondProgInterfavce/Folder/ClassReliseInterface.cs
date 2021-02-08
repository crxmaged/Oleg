using System;

namespace SecondProgInterfavce.Folder
{
	class ClassReliseInterface : InterfaceStep
	{
		int start;
		int value;
		int previous;

		public ClassReliseInterface()
		{
			start = 0;
			value = 0;
			previous = -2;
		}

		public int GoStep()
		{
			previous = value;
			value += 2;
			return value;
		}

		public void Reset()
		{
			value = start;
			previous = start - 2;
		}

		public void SetFirstStep(int point)
		{
			start = point;
			value = start;
			previous = value - 2;
		}
		// new method that don't have Interface

		public int GetPreviousValue()
		{
			return previous;
		}
	}
}
