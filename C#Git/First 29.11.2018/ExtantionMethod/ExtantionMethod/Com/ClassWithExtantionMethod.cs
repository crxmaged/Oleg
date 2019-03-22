using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtantionMethod.Com
{
	static class ClassWithExtantionMethod
	{
		public static void ExMethod (this string value)
		{
			Console.WriteLine(value);	
		}
	}
}
