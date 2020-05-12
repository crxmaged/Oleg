using System;

namespace S_10_2_MultieIndexer.Folder
{
	class ClassUseIndexer
	{
		int[,] doubleArray; // creat array two measures
		int rowsArray, colsArray; // values have number sizes of array (rows/colums)
		public int LengthArray; // too easy, for cycle 
		public bool stepCheck; // for Program class, use to correct index for array

		// constructors:
		public ClassUseIndexer()
		{
			// default
		}

		public ClassUseIndexer(int rows, int cols)
		{ // constructor set size
			rowsArray = rows;
			colsArray = cols;
			doubleArray = new int[rows, cols];
			LengthArray = rows * cols;
		}

		public int this [int indexRows, int indexCols] 
		{ // multiplication indexer
			get
			{
				if (Off(indexRows, indexCols))
				{ // check to correct index for array
					stepCheck = false;
					return doubleArray[indexRows, indexCols];
				}
				else
				{
					stepCheck = true;
					return 0;
				}
			}

			set
			{
				if(Off(indexRows, indexCols))
				{ // check to correct index for array
					doubleArray[indexRows, indexCols] = value;
					stepCheck = false;
				}
				else
				{
					stepCheck = true;
				}
			}
		}
		// method check for correct value
		private bool Off (int indexOfRows, int indexOfCols)
		{
			if (indexOfRows >= 0 & indexOfRows < rowsArray & indexOfCols >= 0 & indexOfCols < colsArray)
			{
				return true;
			}
			else
			{
				// Console.WriteLine("Out of measure!");
				return false;
			}
		}
	}
}
