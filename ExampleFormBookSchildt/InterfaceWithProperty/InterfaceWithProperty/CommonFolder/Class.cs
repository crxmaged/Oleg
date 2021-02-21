using System;

namespace InterfaceWithProperty.CommonFolder
{
	class Class : Interface
	{
		int value;

		public Class()
		{
			value = 0;
		}

		public int NextStep
		{
			get
			{
				value += 2;
				return value;
			}
			set
			{
				this.value = value;
			}
		}
	}
}
	