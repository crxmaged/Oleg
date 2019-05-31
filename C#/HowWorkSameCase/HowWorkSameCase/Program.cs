using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowWorkSameCase
{
	public class Pet // reference type
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var pet = new Pet()
			{
				Name = "Cat",
				Age = 3
			};

			ChangeAge(pet, 12); // 1: method open/work/close but not change current property
			// use "ref" for "pet" if we want change value of properties 
			Console.WriteLine(pet.Age); // 4: ans 3

			Console.ReadLine();
		}

		public static void ChangeAge (Pet pet, int newAge) // 2: location property + "ref"
		{ // 3: after work garbage collector delete this method
			pet = new Pet()
			{
				Name = pet.Name,
				Age = newAge
			};
		}
	}
}
