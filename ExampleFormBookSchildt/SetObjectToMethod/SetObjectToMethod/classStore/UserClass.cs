using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetObjectToMethod.classStore
{
	class UserClass // In this class we have method that get object type
	{
		int alpha, beta;

		public UserClass()
		{
		}

		public UserClass(int i, int j)
		{
			alpha = i;
			beta = j;
		}

		public bool AsSame (UserClass obClass)
		{
			if ((obClass.alpha == alpha) & (obClass.beta == beta))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Copy (UserClass userClass)
		{
			alpha = userClass.alpha;
			beta = userClass.beta;
		}

		public void Show()
		{
			Console.WriteLine("alpha: {0}, beta {1}", alpha, beta);
		}
	}
}
