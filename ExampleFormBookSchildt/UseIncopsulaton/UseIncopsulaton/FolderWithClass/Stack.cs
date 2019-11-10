using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIncopsulaton.FolderWithClass
{
	class Stack
	{
		char[] strk; // mass like a stack
		int tos; // end of stack

		public Stack()
		{

		}
		public Stack (int size) // set size stack (array)
		{
			strk = new char[size]; // instance
			tos = 0;
		}

		public void Push (char ch) // set element fakeStack
		{
			if (tos == strk.Length)
			{
				Console.WriteLine("Stack is full"); // if we set last element
				return; // break method)))
			}
			strk[tos] = ch;
			tos++; // if IsFull == true loop end in main method
		}

		public char Pop () // get elements from fakeStack
		{
			if (tos == 0)
			{
				Console.WriteLine("Stack is empty!"); // if we catch last element of fakeStack
				return (char)0; // break method)))
			}
			tos--;
			return strk[tos];
		}

		public bool IsFull() // check for loop
		{
			return tos == strk.Length;
		}

		public bool IsEmpty() // check for loop
		{
			return tos == 0;
		}

		public int Capacity() // if we want to see current value
		{
			return strk.Length;
		}

		public int GetNum() // Num position of element in array "fakeStack
		{
			return tos;
		}
	}
}
