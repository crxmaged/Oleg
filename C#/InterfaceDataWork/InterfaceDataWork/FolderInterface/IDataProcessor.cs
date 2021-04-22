using System;

namespace InterfaceDataWork.FolderInterface
{
	interface IDataProcessor
	{
		void Process(IDataProvider dataProvider);
	}
}
