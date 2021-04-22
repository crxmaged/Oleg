using System;
using InterfaceDataWork.FolderClass;
using InterfaceDataWork.FolderInterface;

namespace InterfaceDataWork
{
	class Program
	{ // simple code how to use several Inteface with class 
		static void Main(string[] args)
		{
			IDataProcessor process = new ConsoleProcess();
			process.Process(new ClassAPI());
			process.Process(new ClassDb());
			process.Process(new ClassFile());

			Console.ReadLine();
		}
	}
}
