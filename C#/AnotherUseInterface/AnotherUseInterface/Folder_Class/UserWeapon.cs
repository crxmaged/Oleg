using System;
using AnotherUseInterface.Folder_Interface;

namespace AnotherUseInterface.Folder_Class
{
	class UserWeapon
	{
		public void ToDoFire(IWeappon weapon)
		{
			weapon.Fire();
		}

		public void InforAboutObject(IAllInfo @object)
		{
			@object.ShowInfo();
		}
	}
}
