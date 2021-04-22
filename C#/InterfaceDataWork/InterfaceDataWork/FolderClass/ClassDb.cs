using System;
using InterfaceDataWork.FolderInterface;

namespace InterfaceDataWork.FolderClass
{
	class ClassDb : IDataProvider
	{
		public string GetData()
		{
			return "Data from DataBase!";
		}
	}
}
