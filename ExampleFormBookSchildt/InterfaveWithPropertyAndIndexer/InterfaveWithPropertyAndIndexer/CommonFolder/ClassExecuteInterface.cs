using System;

namespace InterfaveWithPropertyAndIndexer.CommonFolder
{
	class ClassExecuteInterface : ICount
	{ // this class execute interfave ICount
		int value;

		public ClassExecuteInterface()
		{
			value = 0;
		}

		public int this[int index]
		{
			get
			{
				value = 0;
				for (int i = 0; i < index; i++)
				{
					value += 2;
				}
				return value;
			}
		}

		public int GetNumber
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
