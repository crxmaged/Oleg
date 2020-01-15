using System;

namespace WorkWithConstructorOverload.FolderWithClass
{
	class OverloadClass
	{
		char[] abc;
		int num;
		// Deafault class
		public OverloadClass()
		{

		}
		// Simple class where set value to array abc and variable num
		public OverloadClass(int size)
		{
			abc = new char[size];
			num = 0;
		}
		// Overload constr if we set object to class (constructor)
		public OverloadClass(OverloadClass obj)
		{
			abc = new char[obj.abc.Length];
			num = obj.num;

			for (int i = 0; i < abc.Length; i++)
			{
				abc[i] = obj.abc[i];
			}
		}

		public void Add (char ch)
		{
			if (num == abc.Length)
			{
				Console.WriteLine("Stack is full!");
				return;
			}

			abc[num] = ch;
			num++;
		}

		public char Div ()
		{
			if (num == 0)
			{
				Console.WriteLine("Srack is empty!");
				return (char) 0;
			}

			num--;
			return abc[num];
		}

		public bool IfFull()
		{
			return num == abc.Length;
		}

		public bool IsEmpty()
		{
			return num == 0; 
		}

		public int GetNum ()
		{
			return num;
		}
	}
}
