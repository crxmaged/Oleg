using System;

namespace OverrideMethod.CommonClass
{
	class DerivedClass : BaseClass
	{
		public override void Try()
		{
			Console.WriteLine("Method from DerivedClass");
		}
	}
}
