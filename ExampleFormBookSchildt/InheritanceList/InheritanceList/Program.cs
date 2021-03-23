using System;
using InheritanceList.FolderClass;

namespace InheritanceList
{
	class Program
	{
		static void Main(string[] args)
		{ // this program shows severals inheritance
			Teacher teacherOne = new Teacher { Name = "Albert", SurName = "Enschteine" };
			Security securityOne = new Security { Name = "John", SurName = "Wuike" };
			Student studentOne = new Student { Name = "Dastyne", SurName = "Hoffman" };

			Persone[] people = { teacherOne, securityOne, studentOne };

			ShowNames(people);

			Console.ReadLine();
		}

		static void ShowNames(Persone [] people)
		{
			foreach (var names in people)
			{
				names.ShowAllName();
			}
		}
	}
}
