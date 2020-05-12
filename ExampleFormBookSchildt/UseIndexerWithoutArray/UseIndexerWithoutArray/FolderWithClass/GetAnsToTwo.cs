using System;


namespace UseIndexerWithoutArray.FolderWithClass
{
	class GetAnsToTwo
	{ // use indexer
		public int this [int index]
		{ // property without array and set accesor, only get!
			get
			{
				if ((index >= 0) && (index < 16))
				{
					return count(index); 
				}
				else
				{
					return -1;
				}
			}
		}

		int count (int number)
		{ // countany number and return result if '(index >= 0) && (index < 16)' ans - true
			int result = 1;

			for (int i = 0; i < number; i++)
			{
				result *= 2;
			}

			return result;
		}
	}
}
