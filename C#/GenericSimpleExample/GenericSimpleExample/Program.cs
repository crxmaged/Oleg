using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSimpleExample
{
	public class A<T> // class with generic type
	{
		public static int Age { get; set; }
	}

	public class B // class with generic type
	{
		public static int Age { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{ // two different instance - two different typies
			A<int>.Age = 10; // first instance 
			A<byte>.Age = 12; // second instance


			B.Age = 20;
			B.Age = 30;

			Console.WriteLine(A<int>.Age); // ans 10
			Console.WriteLine(A<byte>.Age); // ans 12

			Console.WriteLine(B.Age);
			Console.WriteLine(B.Age);

			Console.ReadLine();
		}
	}
}
