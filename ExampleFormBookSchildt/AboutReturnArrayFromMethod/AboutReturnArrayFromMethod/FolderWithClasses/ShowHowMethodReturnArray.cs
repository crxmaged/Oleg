using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutReturnArrayFromMethod.FolderWithClasses
{
	class ShowHowMethodReturnArray
	{
		int num = 100; // default value for array, because we use 'return'
		public int[] Factor(int sizeCheckNumber, out int amountFactors)
		{ // operator out must assigned in method
			int i, j; // use for count all factor elements in number
			int[] factors; // use for save all factors elements
			if (sizeCheckNumber != 0) // parametr sizeCheckNumber have to not zero 
			{
				factors = new int[sizeCheckNumber / 2]; // set size array
			}
			else
			{
				factors = new int[num]; // 'default' size array
			}
			for (i = 2, j = 0; i < sizeCheckNumber/2 + 1; i++)
			{ // get all factor elements in this loop
				if ((sizeCheckNumber%i) ==0) 
				{
					factors[j] = i; // set factor number in array
					j++; // next step for save in array factor element
				}
			}

			amountFactors = j; // set amount how many factor elements we have
			return factors; // return array with all factor elements
		}
	}
}
