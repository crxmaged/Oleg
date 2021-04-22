using System;

namespace ThrowException
{
	class Program
	{ // page 415
		static void Main(string[] args)
		{
			try
			{ // create work exception DivideByZeroException with throw
				Console.WriteLine("Creat user exception with key word 'throw'");
				throw new DivideByZeroException(); // call default constructor from DivideByZeroException class
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("DivideByZeroException - exception call!!!");
			}

			Console.WriteLine("Code steal work after try/catch block");

			Console.ReadLine();
		}
	}
}
