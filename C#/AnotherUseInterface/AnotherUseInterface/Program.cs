using System;
using AnotherUseInterface.Folder_Class;

namespace AnotherUseInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			UserWeapon userPlayer = new UserWeapon();

			Weapon[] AllWeapon = { new Bow(), new Gun(), new LaserGun() };
			userPlayer.InforAboutObject(new Tree());

			foreach (var guns in AllWeapon)
			{
				userPlayer.InforAboutObject(guns);
				userPlayer.ToDoFire(guns);
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
