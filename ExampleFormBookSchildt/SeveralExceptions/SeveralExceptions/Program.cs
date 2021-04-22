using System;
using SeveralExceptions.FolderExceptions;

namespace SeveralExceptions
{
	class Program
	{ // page 427
		static void Main(string[] args)
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					if (i == 0) throw new ExceptionB("Call ExceptionB!!! B!!!");
					else if (i == 1) throw new ExceptionA("Call ExceptionA!!! A!!!");
					else throw new Exception("Call base Exception!!!");
				}
				catch (ExceptionB text) // lowest Exception
				{
					Console.WriteLine(text);
				}
				catch (ExceptionA text) // almost base Exception
				{
					Console.WriteLine(text);
				}
				catch (Exception text) // base Exception
				{
					Console.WriteLine(text);
				}
			}
			Console.ReadLine(); // Pause
		}
	}
}
