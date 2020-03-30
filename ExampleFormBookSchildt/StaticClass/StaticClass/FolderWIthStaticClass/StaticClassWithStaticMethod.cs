using System;

namespace StaticClass.FolderWIthStaticClass
{ // Show static class
	static public class StaticClassWithStaticMethod
	{
		static public double Replic(double num)
		{
			return 1/num;
		}

		static public double LookFractPartOfNumber (double num)
		{
			return num - (int)num; 
		}

		static public bool LookEvenNumber (double num)
		{
			return (num % 2) == 0 ? true : false;
		}

		static public bool LookOddNumber (double num)
		{
			return !LookEvenNumber(num);
		}
	}
}
