using System;

namespace WotkWithInterface.CommonFolder
{
	class PrimeNumbers : CommonInterface
	{
		int currentValue;
		int startpoint;


		public PrimeNumbers()
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
			startpoint++;
			for (int n = startpoint; n <= 1000000; n++)
			{
				if (n % 2 != 0)
				{
					if (startpoint < n)
					{
						startpoint++;
					}
					currentValue = n;
					break;
				}
			}
			return currentValue;
		}

		public void SetFirstStep(int point)
		{
			startpoint = point;
			currentValue = startpoint;
		}
	}
}
