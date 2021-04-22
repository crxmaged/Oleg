using System;
using AnotherUseInterface.Folder_Interface;

namespace AnotherUseInterface.Folder_Class
{
	abstract class Weapon: IAllInfo, IWeappon
	{
		public abstract int Damage { get; }
		public abstract void Fire();

		public void ShowInfo()
		{
			Console.WriteLine("Name weapon: {0}, has damage: {1}", GetType().Name, Damage);
		}
	}
}
