using System;

namespace Indexer.FolderWIthClass
{
	class ClassWithArrayUseIndexer
	{
		int[] array_A;

		public int Length;
		public bool Check;

		public ClassWithArrayUseIndexer()
		{
			// default constructor
		}

		public ClassWithArrayUseIndexer (int size)
		{ // set size array
			array_A = new int[size];
			Length = size;
		}

		public int this [int index]
		{ // creat indexer
			get
			{
				if (CheckForOverload(index))
				{
					Check = false;
					return array_A[index];
				}
				else
				{
					Check = true;
					return 0;
				}
			}
			set
			{
				if(CheckForOverload(index))
				{
					array_A[index] = value;
					Check = false;
				}
				else
				{
					Check = true;
				}
			}
		}

		public bool CheckForOverload (int index)
		{ // Chech can we use this index in current array
			if (index >= 0 & index < Length)
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
