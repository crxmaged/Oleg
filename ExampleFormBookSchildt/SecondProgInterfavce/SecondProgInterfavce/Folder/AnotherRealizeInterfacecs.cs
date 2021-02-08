using System;

namespace SecondProgInterfavce.Folder
{
	class AnotherRealizeInterfacecs : InterfaceStep
	{
		int start;
		int value;

		public AnotherRealizeInterfacecs ()
		{
			start = 0;
			value = 0;
		}

		public int GoStep()
		{
			/*
			int i, j;
			bool isprime;
			*/
			start++;
			for(int n = start; n <= 1000000; n++)
			{
				if (n%2 != 0)
				{
					if (start < n)
					{
						start++;
					}
					value = n;
					break;
				}
			}

			/*
			value++;
			for (i = value; i < 1000000; i++)
			{
				isprime = true;
				for (j = 2; j <= i / j; j++)
				{ // this cycle needs to find value by two (valu/2 == 0)
					if ((i % j) == 0)
					{
						isprime = false;
						break; // break second cycle for
					}
				}
				if (isprime)
				{
					value = i;
					break; // break first cycle for
				}
			}
			*/
			return value;
		}

		public void Reset()
		{
			value = start;
		}

		public void SetFirstStep(int point)
		{
			start = point;
			value = start;
		}

	}
}
