using System;

namespace AnotherUseInterface.Folder_Class
{
	class LaserGun: Weapon
	{
		public override int Damage => 8;
		public override void Fire()
		{
			Console.WriteLine("Shoot laser!!!");
		}
	}
}
