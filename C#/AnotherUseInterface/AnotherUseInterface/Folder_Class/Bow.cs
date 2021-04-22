using System;

namespace AnotherUseInterface.Folder_Class
{
	class Bow: Weapon
	{
		public override int Damage => 3;
		public override void Fire()
		{
			Console.WriteLine("Shoot arrow!!!");
		}
	}
}
