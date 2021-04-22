using System;
using CreateUserCatchException.Folder;

namespace CreateUserCatchException.Folder
{
	class UseArray
	{
		int[] classArray; // array using in this class
		int lessIndex; // first element in array
		int highIndex; // last elemetn in array
		public int GetFistIndex, GetLastIndex;

		public UseArray()
		{ // don't use this constructor by need anyway
			// default constructor
		}

		public UseArray(int firstIndex, int lastIndex)
		{ // this constructor sets size of array 
			lastIndex++; // rise value of last element of array for check
			if(lastIndex <= firstIndex)
			{ // call user catch if call exception out range of array
				throw new RangeArrayException("\n Try set first indext that not less than last");
			}	// send this message to constructor in Exception class
			classArray = new int [lastIndex - firstIndex]; // set size array
			LengthArray = lastIndex - firstIndex; // appart save size array like value

			lessIndex = firstIndex; // set first index array
			highIndex = --lastIndex; // set last index array
			GetFistIndex = firstIndex; // use this fields out of this class
			GetLastIndex = lastIndex;
		}
		// creat property for class UseArray where save size of array
		public int LengthArray { get; private set; }
		// creat indexer for class UseArray
		public int this [int index]
		{
			get
			{
				if(Check(index))
				{
					return classArray[index - lessIndex];
				}
				else
				{
					throw new RangeArrayException("\n Over current range array");
				} // send this message to constructor in Exception class
			}
			set
			{
				if (Check(index))
				{
					classArray[index - lessIndex] = value;
				}
				else
				{
					throw new RangeArrayException("\n Over current range array");
				} // send this message to constructor in Exception class
			}
		}
		// method for check that this index can use in current array
		private bool Check(int index)
		{
			if (index >= lessIndex & index <= highIndex)
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
