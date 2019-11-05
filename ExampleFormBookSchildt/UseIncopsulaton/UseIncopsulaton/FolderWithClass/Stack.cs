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
		public Stack (int size)
		{
			strk = new char[size]; // instance
			tos = 0;
		}

		public void Push (char ch)
		{
			if (tos == strk.Length)
			{
				Console.WriteLine("Stack is full");
				return;
			}
			strk[tos] = ch; tos++;
		}

		public char Pop ()
		{
			if (tos == 0)
			{
				Console.WriteLine("Stack is empty!");
				return (char)0;
			}
			tos--;
			return strk[tos];
		}

		public bool IsFull()
		{
			return tos == strk.Length;
		}

		public bool IsEmpty()
		{
			return tos == 0;
		}

		public int Capacity()
		{
			return strk.Length;
		}

		public int GetNun()
		{
			return tos;
		}
	}
}
