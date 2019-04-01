using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTask
{
	class Program
	{
		static void Second()
		{
			while (true)
			{
				Console.WriteLine("                 {0}", "Second thread!");
				Thread.Sleep(200);
			}
		}


		static void Main(string[] args)
		{
			ThreadStart writeSecond = new ThreadStart(Second);
			Thread thread = new Thread(writeSecond);
			thread.Start();

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Prime thread");
				Thread.Sleep(200);
			}

			thread.IsBackground = true;

			// Console.ReadLine();
		}

	}
}
