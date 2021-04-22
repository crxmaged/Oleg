using System;
using InterfaceDataWork.FolderInterface;

namespace InterfaceDataWork.FolderClass
{
	class ConsoleProcess : IDataProcessor
	{
		public void Process(IDataProvider dataProvider)
		{
			Console.WriteLine(dataProvider.GetData());
		} // method dataProvider.GetData get string 
	}
}
