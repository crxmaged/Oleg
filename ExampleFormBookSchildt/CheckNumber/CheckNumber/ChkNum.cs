using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
	class ChkNum
	{
		public bool IsPrime (int x)
		{
			if (x <= 1) return false;
			for (int i = 2; i <= x / i; i++) // go anothe step if don't work return on 16 line
			{
				if ((x % i) == 0) return false;
			}
			return true;
		}
	}
}
