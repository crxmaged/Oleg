using System;
using PreArgInMeth.ClassFold;

namespace PreArgInMeth
{
	class Program
	{
		static void Main(string[] args)
		{
			CallMeToShow.ShowText("Show text in console! Hello)))");
			CallMeToShow.ShowText("Show text in console! Hello)))", 4, 10);
			CallMeToShow.ShowText("Show text in console! Hello)))", 9);
			CallMeToShow.ShowText(start: 5, str:"Same text5 show how we can use Method with several arguments",stop: 12);

			Console.ReadLine();
		}
	}
}
