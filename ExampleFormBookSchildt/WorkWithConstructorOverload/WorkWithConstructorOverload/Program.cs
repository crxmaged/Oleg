using System;
using WorkWithConstructorOverload.FolderWithClass;

namespace WorkWithConstructorOverload
{
	class Program
	{
		static void Main(string[] args)
		{
			OverloadClass stack = new OverloadClass(15);

			char ch;
			int i;

			Console.WriteLine("Set symbols to stack!");
			for(i = 0; !stack.IfFull(); i++)
			{
				stack.Add((char)('A' + i));
			}
			// Creat copy of stack
			OverloadClass anotheStack = new OverloadClass(stack);

			Console.Write("First stack have: ");
			while( !stack.IsEmpty())
			{
				ch = stack.Div();
				Console.Write("{0}", ch);
			}

			Console.WriteLine();

			Console.Write("Second stack have: ");
			while (!anotheStack.IsEmpty())
			{
				ch = anotheStack.Div();
				Console.Write("{0}", ch);
			}

			Console.ReadLine();
		}
	}
}
