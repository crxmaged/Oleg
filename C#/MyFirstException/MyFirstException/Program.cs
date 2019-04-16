using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstException
{
	public class MYException : Exception // Creat personal exception
	{
		public void Method() 
		{
			Console.WriteLine("User Exception!");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			try
			{ // operator throw call Exception
				throw new MYException(); // Call user exception MYException without bool 
			}

			catch (MYException e)
			{
				Console.WriteLine("Use user exception!"); // Show exception 
				e.Method();
			}

			Console.ReadLine();
		}
	}
}
