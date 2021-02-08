using System;

namespace OverrideMethod.CommonClass
{
	class OffspringClass : BaseClass
	{
		public override void Try()
		{
			Console.WriteLine("Method from OffspringClass");
		}
	}
}
