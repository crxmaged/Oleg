using System;
using UseIncopsulaton.FolderWithClass;

namespace UseIncopsulaton
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack stk1 = new Stack(10); // elements in array oy sorry in stack)
			Stack stk2 = new Stack(10);
			Stack stk3 = new Stack(10);
			char ch;
			int i;

			// set elements to stack
			Console.WriteLine("Set symbols from A to J in stack {0}", nameof(stk1));
			for (i = 0; !stk1.IsFull(); i++)
			{
				stk1.Push((char)('A' + i)); // set new char symbol (one step)	
			}
			if (stk1.IsFull())
			{
				Console.WriteLine("Stack {0} is full", nameof(stk1));
			}
			// get (write console)
			Console.WriteLine("Stack have: ");
			for (;!(stk1.IsEmpty());)
			{
				Console.Write("{0}", ch = stk1.Pop());
			}
			Console.WriteLine();
			if (stk1.IsEmpty())
			{
				Console.WriteLine("Stack {0} is empty!", nameof(stk1));
			}
			Console.WriteLine("Set symbols from A to J in stack {0} again!!!", nameof(stk1));
			for (i = 0; !stk1.IsFull(); i++)
			{
				stk1.Push((char)('A' + i)); // set new char symbol (one step)	
			}
			if (stk1.IsFull())
			{
				Console.WriteLine("Stack {0} is full", nameof(stk1));
			}
			Console.WriteLine("In Stack {0} we set elements from Stack {1} with reverse combination!", nameof(stk1), nameof(stk2));
			for (; !(stk1.IsEmpty());)
			{
				ch = stk1.Pop();
				stk2.Push(ch);
			}
			// get (write console)
			Console.WriteLine("Stack have: ");
			for (; !(stk2.IsEmpty());)
			{
				Console.Write("{0}", ch = stk2.Pop());
			}
			Console.WriteLine();
			if (stk2.IsEmpty())
			{
				Console.WriteLine("Stack {0} is empty!", nameof(stk2));
			}
			Console.WriteLine("\n");
			// use Stack stk3 and set 1/2 elements of Stack stk1
			Console.WriteLine("In Stack stk3 set half elements of Stack stk1");
			for (i = 0; i < stk3.Capacity()/2; i++)
			{
				stk3.Push((char)('A' + i));
			}
			Console.WriteLine("size Stack {0} is: {1}", nameof(stk3), stk3.Capacity());
			Console.WriteLine("Number elements in Stack {0} is: {1}", nameof(stk3), stk3.GetNum());
			Console.ReadLine();
		}
	}
}
