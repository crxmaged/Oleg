using System;

namespace SetArray.Folder
{
	class WorkWithArray
	{
		int[] array; // default array for work and show how to use indexers and properties
		int startPoint; // first array index
		int endPoint; // last array index
		public int firstPoint; // use abroad the class (first index array)
		public int lastPoint; // use abroad the class (last index array) 

		public WorkWithArray ()
		{
			// default constructor
		}

		public WorkWithArray(int start, int end) // value start have to be lower than value end
		{ // users constructor for set size, start and end points for array
			firstPoint = start; // local properties get value from paramenters
			lastPoint = end; // set end point for implement size array
			end++; // speciale rise size for correct set size array
			if(end <= start)
			{
				Console.WriteLine("Set another value!!!");
				end = 1; // set minimal correct size of array
				start = 0;
			}
			array = new int[end - start]; // length array
			Leght = end - start; // save length in value 

			startPoint = start; // array start this point
			endPoint = --end; // last this point, but we have also 0 index, don't forget it (ovelaod) 
		} // soo we must to decrease one number variable endPoint 

		public int Leght { get; private set; } // can get size array from outside this class
		public bool Error { get; private set; } // check correct request

		public int this [int index ] // indexer easy way to get any number from array
		{ // or set value to any elements in array
			get
			{
				if (Check(index)) // before we get number of elemnt from array 
				{ // we check that this query is correct
					Error = false; // alright and we don't have any problem with index
					return array[index - startPoint];  // this expration allow use negative
				} // value in array
				else
				{
					Error = true;
					return 0;
				}
			}
			set
			{
				if (Check(index))
				{
					array[index - startPoint] = value;
					Error = false;
				}
				else
				{
					Error = true;
				}
			}
		}

		private bool Check(int someindex) // check method test than user 
		{ // use index in array range
			if (someindex >= startPoint && someindex <= endPoint)
			{
				return true;
			}
			return false;
		}
	}
}
