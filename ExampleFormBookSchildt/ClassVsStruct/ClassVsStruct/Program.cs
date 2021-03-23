using System;
using ClassVsStruct.MyFolder;

namespace ClassVsStruct
{
	class Program
	{ // page 394
		static void Main(string[] args)
		{
			// Show diffrence between class and struct
			MyClass ClassObject_A = new MyClass();
			MyClass ClassObject_B = new MyClass();
			MyStruct Strucu_A;
			MyStruct Strucu_B;

			ClassObject_A.var = 22;
			ClassObject_B.var = 33;

			Console.WriteLine("Member of two classes have values: of class_1: {0} and of class_2: {1}", ClassObject_A.var, ClassObject_B.var);
			Console.WriteLine("Then Class_1 equale Class_2, result: ");

			ClassObject_A = ClassObject_B;
			ClassObject_B.var = 44;

			Console.WriteLine("Class_1 = {0}", ClassObject_A.var);
			Console.WriteLine("Show how work class (reference type)");
			Console.WriteLine("Next show how work value type - struct!");

			Strucu_A.var = 11;
			Strucu_B.var = 55;


			Console.WriteLine("Member of two structs have values: of class_1: {0} and of class_2: {1}", Strucu_A.var, Strucu_B.var);
			Console.WriteLine("Then Struct_1 equale Struct_2, result: ");

			Strucu_A = Strucu_B;
			Strucu_B.var = 77;

			Console.WriteLine("Struct_1 = {0}", Strucu_A.var);

			Console.ReadLine();
		}
	}
}
