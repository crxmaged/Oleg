using System;

namespace UseInterface.CommonFolder
{
	interface ISeries
	{
		int GetNext(); // go one step
		void Reset(); // reset to first value
		void SetStartPoint(int x); // set first point
	}
}
