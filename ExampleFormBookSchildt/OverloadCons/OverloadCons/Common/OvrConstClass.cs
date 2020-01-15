using System;

namespace OverloadCons.Common
{
	class OvrConstClass
	{
		public int xl;

		public OvrConstClass()
		{
			Console.WriteLine("Default constructor without params where field xl = {0}", xl);
		}

		public OvrConstClass(int i)
		{
			xl = i;
		}

		public OvrConstClass(double i)
		{
			xl = (int) i;
		}

		public OvrConstClass(int i, int n)
		{
			xl = i + n;
		}
	}
}
