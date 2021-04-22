using System;

namespace TryCatchFinally.Folder
{
	class CheckExceptions
	{
		public static void Exceptio(int what)
		{
			int number;
			int[] arrayNumbers = new int[2];

			Console.Write("If param equal {0} ", what);
			try // use try to show how work catch and block finally
			{
				switch (what)
				{
					case 0:
						number = 100 / what; // first exception if variable what is '0'
						break; // exception divided to zero
					case 1:
						arrayNumbers[4] = 100; // second exception if variable what is '1'
						break; // exception out range of array 
					case 2:
						return; // go to finally region
				}
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Exception - try divide to zero!");
				return; // out from this catch block
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Exception - index out of the current array");
			}
			finally
			{
				Console.WriteLine("Finally, finished Try/Catch/Finally - block");
			}
		}
	}
}
