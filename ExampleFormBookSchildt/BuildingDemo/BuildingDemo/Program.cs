using System;
using BuildingDemo.Common;

namespace BuildingDemo
{
	class Program
	{
		static void Main(string[] args)
		{ // Exmaple use method with return no void
			Building house = new Building();
			Building office = new Building();

			int areaPP;

			house.occupants = 4;
			house.area = 2500;
			house.floors = 2;

			office.occupants = 25;
			office.area = 4200;
			office.floors = 3;

			areaPP = house.AreaPerPerson();
			Console.WriteLine("House have {0} person, {1} area, {2} floor(s)", house.occupants, house.area, house.floors);
			Console.WriteLine("Area for one person {0}", areaPP);

			areaPP = office.AreaPerPerson();
			Console.WriteLine("Ofiice have {0} person, {1} area, {2} floor(s)", office.occupants, office.area, office.floors);
			Console.WriteLine("Area for one person {0}", areaPP);

			Console.ReadLine();
		}
	}
}
