using System;
using CreateUserCatchException.Folder;

namespace CreateUserCatchException
{
	class Program
	{ // page 425
		static void Main(string[] args)
		{ // creat object array and set size
			try // block without exceptions
			{
				UseArray FirstArray = new UseArray(-10, 10);
				UseArray SecondArray = new UseArray(2, 22);
				// show what have first object
				Console.WriteLine("Length first array is: {0}", FirstArray.LengthArray);
				for (int i = FirstArray.GetFistIndex; i < FirstArray.GetLastIndex; i++)
				{
					FirstArray[i] = i * 2;
				}
				Console.Write("First object have values: { ");
				for(int i = FirstArray.GetFistIndex; i < FirstArray.GetLastIndex; i++)
				{
					Console.Write("{0}, ", FirstArray[i]);
				}
				Console.WriteLine("}");

				// show what have second object
				Console.WriteLine("Length first array is: {0}", SecondArray.LengthArray);
				for (int i = SecondArray.GetFistIndex; i < SecondArray.GetLastIndex; i++)
				{
					SecondArray[i] = i * 2;
				}
				Console.Write("First object have values: { ");
				for (int i = SecondArray.GetFistIndex; i < SecondArray.GetLastIndex; i++)
				{
					Console.Write("{0}, ", SecondArray[i]);
				}
				Console.WriteLine("}");
			}
			catch (RangeArrayException exc)
			{
				Console.WriteLine("{0}", exc);
			}
			// block with exceptions
			try
			{
				UseArray ThirdArray = new UseArray(10, -10); // Fails
			} // can't set second index less than first
			catch (RangeArrayException exc)
			{
				Console.WriteLine(exc);
			}
			// anothe block with exception
			try
			{
				UseArray FourthArray = new UseArray(1, 12);
				for (int i = FourthArray.GetFistIndex; i < FourthArray.GetLastIndex; i++)
				{
					FourthArray[i] = i * 3;
				}
				Console.Write("Object have members: { ");
				for (int i = FourthArray.GetFistIndex; i < FourthArray.GetLastIndex + 10; i++)
				{
					Console.Write("{0}, ", FourthArray[i]);
				}
				Console.Write("}");
			}
			catch (RangeArrayException exc)
			{
				Console.WriteLine(exc);
			}

			Console.ReadLine();
		}
	}
}
