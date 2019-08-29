using System;

namespace BuildingDemo.Common
{
	class Building
	{
		public int floors;
		public int area;
		public int occupants;

		public int AreaPerPerson ()
		{
			return area / occupants;
		}
	}
}
