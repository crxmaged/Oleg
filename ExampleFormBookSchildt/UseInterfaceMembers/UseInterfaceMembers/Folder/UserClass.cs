using System;

namespace UseInterfaceMembers.Folder
{ // two interface have same name method but diffriends realize
	class UserClass : InterfaceA, InterfaceB
	{ // page 390 
		int InterfaceA.Method(int number) // use 'forvard' referance
		{ // sum
			return number + number;
		}

		int InterfaceB.Method(int number)
		{ // mult
			return number * number;
		}
		// creat two method to call them in anothe classes
		public int Method_A (int number)
		{ 
			InterfaceA InterfaceObject_A = this;
			return InterfaceObject_A.Method(number);
		}

		public int Method_B (int number)
		{
			InterfaceB InterfaceObject_B = this;
			return InterfaceObject_B.Method(number);
		}


	}
}
