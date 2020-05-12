using System;
using S_10_2_MultieIndexer.Folder;

namespace S_10_2_MultieIndexer
{
	class Program
	{
		static void Main(string[] args)
		{
			int x;
			ClassUseIndexer Array2D = new ClassUseIndexer(5, 7);

			for (int i = 0; i < Array2D.LengthArray * 2; i++)
			{
				Array2D[i, i] = i * 5; // use path of property set
			}

			for (int i = 0;  i < Array2D.LengthArray * 2; i++)
			{
				x = Array2D[i, i]; // use path of property get
				{
					Console.Write(" elemen {1}: {0};", x, i);
				}
			}
			Console.WriteLine();

			Console.WriteLine("Show message if over arange array!");
			for (int i = 0; i < Array2D.LengthArray * 2; i++)
			{
				Array2D[i, i] = i * 5; // use path of property set
				if (Array2D.stepCheck)
				{
					Console.WriteLine("Too much for this array!");
				}
			}

			for (int i = 0; i < Array2D.LengthArray * 2; i++)
			{
				x = Array2D[i, i];
				if (!Array2D.stepCheck)
				{
					Console.Write(" element {1}: {0};", x, i);
				}
				else
				{
					Console.WriteLine("Too much for this array!");
				}
			}

			Console.ReadLine();
		}
	}
}
