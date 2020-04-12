using System;

namespace S_10_1_OverloadIndexers.Folder_With_Class
{
	class WorkWithIndexers
	{
		int[] array; // creat array!

		public int length; // variable have value size (length) array

		public WorkWithIndexers() 
		{
			// default constructor
		}

		public WorkWithIndexers(int size)
		{ // set size (length) array
			array = new int[size];
			length = size;
		}

		public int this [int index]
		{ // use int idexer
			get // get value from array
			{
				if (Check(index)) // check for index value in array 
				{
					return array[index]; // ok
				}
				else 
				{
					return 0; // not ok :(
				}
			}
			set // set value on current index
			{
				if (Check(index)) // check for index value in array 
				{
					array[index] = value; // set value is all ok
				}
				else
				{
					value = 0; // if we have problem with index
				}
			}
		}

		public int this[double indx]
		{ // use int idexer
			get // get value from array
			{
				int index;
				// first we need conver value from double to integer
				if ((indx - (int)indx) < 0.5)  // around
				{
					index = (int)indx; // around to low
				}
				else
				{
					index = (int)indx + 1; // around to high
				}

				if (Check(index)) // check for index value in array 
				{
					return array[index]; // ok
				}
				else
				{
					return 0; // not ok :(
				}
			}
			set // set value on current index
			{
				int index;

				if ((indx - (int)indx) < 0.5)  // around
				{
					index = (int)indx; // around to low
				}
				else
				{
					index = (int)indx + 1; // around to high
				}

				if (Check(index)) // check for index value in array 
				{
					array[index] = value; // set value is all ok
				}
				else
				{
					value = 0; // if we have problem with index
				}
			}
		}

		public bool Check (int index)
		{ // helps to check value index
			if (index >= 0 & index < array.Length)
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
