using System;

namespace AutoProperty.SomeFolder
{
	class UseAutoProperty
	{ // Use autoProperty, array and indexer
		int[] array;

		public UseAutoProperty()
		{
		}

		public UseAutoProperty(int size)
		{
			array = new int[size];
			Lenght = size;
		}

		public int Lenght { get; private set; }
		// use for work with array
		public bool CheckError { get; private set; }
		// use property to show if we have incorrect index
		public int this [int index]
		{ // use indexer to set and get value of array
			get
			{
				if (CheckIndex(index))
				{
					CheckError = false;
					return array[index];
				}
				else
				{
					CheckError = true;
					return -1;
				}
			}
			set
			{
				if (CheckIndex(index))
				{
					array[index] = value;
					CheckError = false;
				}
				else
				{
					CheckError = true;
				}
			}
		}

		private bool CheckIndex (int index)
		{ // this method check size array and index not over flow array
			if ((index >= 0) & (index < Lenght))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
