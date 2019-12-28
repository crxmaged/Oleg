using System;

class Solution
{
	public static int NumOffices(char[][] grid)
	{
		int result = 0;
		// place your code here
		int col = 0;
		bool xheck = false;

		for (int n = 0; n < grid.GetLength(0); n++)
		{
			for (int k = 0; k < grid[n].Length; k++)
			{
				if (xheck)
				{
					if (grid[n][col] == '0')
					{
						result++;
					}
					else
					{
						break;
					}
					xheck = false;
				}
				if (grid[n][k] != '0')
				{
					col = k;
					// result++;
					xheck = true;
					break;
				}
			}
		}
		Console.WriteLine(result);
			return result;
	}
}

namespace Rextester
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var matrix = GetMatrix();
			var numOffices = Solution.NumOffices(matrix);
			Console.WriteLine(numOffices);
			Console.ReadLine();
		}

		public static char[][] GetMatrix()
		{
			var rows = int.Parse(Console.ReadLine());
			var cols = int.Parse(Console.ReadLine());

			char[][] matrix = new char[rows][];
			for (var i = 0; i < rows; i++)
			{
				var line = Console.ReadLine();
				matrix[i] = line.ToCharArray();
			}
			return matrix;
		}
	}
}
