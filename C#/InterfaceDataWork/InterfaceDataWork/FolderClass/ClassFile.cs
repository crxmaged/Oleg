using System;
using InterfaceDataWork.FolderInterface;

namespace InterfaceDataWork.FolderClass
{
	class ClassFile : IDataProvider
	{
		public string GetData()
		{
			return "Data from File!";
		}
	}
}
