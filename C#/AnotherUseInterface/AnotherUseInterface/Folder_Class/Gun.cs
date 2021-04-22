using System; 

namespace AnotherUseInterface.Folder_Class
{
	class Gun: Weapon
	{
		public override int Damage => 5;
		public override void Fire()
		{
			Console.WriteLine("Shoot bullet fire!!!");
		}
	}
}
