using System;


namespace PropertyOnlyGet.FolderForClass
{
	class UseProperty
	{
		int[] array; // array 
		int length; // length of array

		public bool ErrFlag; // use for check correct value set/get from array in indexer

		public UseProperty() { } // default constructor

		public UseProperty(int size) // user constructor set value for array and anothe value
		{
			array = new int[size];
			length = array.Length;
		}

		public int Length // Use Property only get
		{
			get
			{
				return length;
			}
		}

		public int this [int index]
		{ // Use indexer
			get
			{
				if (Check(index))
				{
					ErrFlag = false;
					return array[index];
				}
				else
				{
					ErrFlag = true;
					return 0;
				}
			}
			set
			{
				if (Check(index))
				{
					array[index] = value;
					ErrFlag = false;
				}
				else
				{
					ErrFlag = true;
				}
			}
		}

		private bool Check (int index)
		{ // private method - check use correct index in array
			if (index >= 0 && index < length)
			{
				return true;
			}
			return false;
		}
	}
}
