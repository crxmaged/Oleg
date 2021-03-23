using System;
using UserStruct.Folder;

namespace UserStruct
{
	class Program
	{ // page 396
		static void Main(string[] args)
		{
			Console.WriteLine("Look this transaction!!!");

			Operation operation_1 = new Operation("asdf_234", 2222.44);
			Operation operation_2 = new Operation("phkl_001", 2345.01);
			Operation operation_3 = new Operation("ttqd_162", 0.5);

			operation_1.ShowTrasation();
			operation_2.ShowTrasation();
			operation_3.ShowTrasation();

			Console.ReadLine();
		}
	}
}
