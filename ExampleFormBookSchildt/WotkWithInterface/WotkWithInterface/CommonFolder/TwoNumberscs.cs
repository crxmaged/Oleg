using System;

namespace WotkWithInterface.CommonFolder
{
	class TwoNumberscs : CommonInterface
	{
		int currentValue;
		int startpoint;


		public TwoNumberscs()
		{
			currentValue = 0;
			startpoint = 0;
		}

		public void BackToFirstPointStep()
		{
			currentValue = startpoint;
		}

		public int GoStep()
		{
			currentValue += 2;
			return currentValue;
		}

		public void SetFirstStep(int point)
		{
			startpoint = point;
			currentValue = startpoint;
		}
	}
}
