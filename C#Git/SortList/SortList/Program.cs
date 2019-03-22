using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList<string, int> sl = new SortedList<string, int>();
			sl.Add("A", 73);
			sl.Add("B", 59);
			sl.Add("C", 1);
			sl.Add("D", 95);
			sl.Add("E", 72);
			//sl.Remove("A");
			Console.WriteLine("Sorted List: ");
			foreach (string s in sl.Keys)
			{
				Console.WriteLine(s + ":" + sl[s]);
				Console.WriteLine("\nCount: " + sl.Count);
				Console.ReadLine();			}
		}
	}
}
