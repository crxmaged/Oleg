using System.Linq;
using System.Text;
//using ApartString;

namespace ApartString
{
	public class SplitString
	{
		public static string[] Solution(string str)
		{
			if (str == null || str.All(c => c.Equals('_') || c.Equals('-') || c.Equals('>') || c.Equals('<')))
			{
				return null;
			}
			else
			{
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < str.Length; i++)
				{
					sb.Append(str[i]);
					if ((i + 1) % 2 == 0)
					{
						if (i < str.Length -1)
							sb.Append(' ');
					}
						
					if (i == (str.Length - 1))
					{
						if (i % 2 == 0)
							sb.Append('_');
					}
				}
				string formatted = sb.ToString();
				//System.Console.WriteLine(formatted + "!");
				string[] array = formatted.Split(' ');
				//System.Console.WriteLine(array.Length);
				return array;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine(SplitString.Solution("abcdef").ToString());

			System.Console.ReadLine();
			/*
			string input = "123456789vjlvjlvlv9";
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < input.Length; i++)
			{
				if (i % 2 == 0)
					sb.Append(' ');
				sb.Append(input[i]);
				if (i == (input.Length - 1))
				{
					if (i % 2 == 0)
						sb.Append('_');
				}
			}
			string formatted = sb.ToString();
			string[] array = formatted.Split(' ');
			Console.WriteLine(formatted);
			Console.ReadLine();
			*/
		}
	}
}
