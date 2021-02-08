using System;

namespace UseInterface.CommonFolder
{
	class ByTwos : ISeries
	{
		int startPoint;
		int value;

		public ByTwos()
		{
			startPoint = 0;
			value = 0;
		}

		public int GetNext()
		{
			value += 2;
			return value; 
		}

		public void Reset()
		{
			value = startPoint;
		}

		public void SetStartPoint(int point)
		{
			startPoint = point;
			value = startPoint;
		}
	}
}
