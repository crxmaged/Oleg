using System;
using InterfaceDataWork.FolderInterface;

namespace InterfaceDataWork.FolderClass
{
	class ClassAPI : IDataProvider
	{
		public string GetData()
		{
			return "Data from API!";
		}
	}
}
