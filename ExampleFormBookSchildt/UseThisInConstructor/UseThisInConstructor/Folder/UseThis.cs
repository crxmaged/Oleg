using System;

namespace UseThisInConstructor.Folder
{
	class UseThis
	{
		public int x, y;
		 // First do this after constructor where this stand
		public UseThis () : this(0, 0)
		{
			Console.WriteLine("Default constructor!");
		}

		public UseThis (UseThis obj): this (obj.x, obj.y)
		{
			Console.WriteLine("Constructor with argument obj type UseThis");
		}

		public UseThis (int x, int y)
		{
			this.x = x;
			this.y = y;
			Console.WriteLine("Constructor where set value variable x: {0} and y: {1}", x, y);
		}
	}
}
