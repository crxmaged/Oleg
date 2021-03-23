using System;
using UseStruct.Folder;

namespace UseStruct
{
	class StartPoint
	{
		static void Main(string[] args)
		{
			Book BookObject1 = new Book("Gerberd Shild", "Some information about C#", 2010);
			Book BookObject2 = new Book(); // Defaiult constructor
			Book BookObject3; // Don't use new - struct constructor 

			Console.WriteLine("Inforamtion about first book: author is {0}, name of book is {1} and book start aviable to buy from {2} year", BookObject1.Author, BookObject1.Title, BookObject1.Copyright);

			if (BookObject2.Title == null)
			{
				Console.WriteLine("Second book empty we can fill it!");
			}

			BookObject2.Author = "Robert Zhelyazniy";
			BookObject2.Title = "Amber";
			BookObject2.Copyright = 1987;

			Console.WriteLine("After fill data about second book! Can read informaton about this book!");

			Console.WriteLine("Inforamtion about second book: author is {0}, name of book is {1} and book start aviable to buy from {2} year", BookObject2.Author, BookObject2.Title, BookObject2.Copyright);

			// if object struct tipe don't have any data. Befor get same data need to set it!
			// Console.WriteLine(BookObject3.Title); - don't have default value

			BookObject3.Title = "Rules Driver Lisens";
			Console.WriteLine(BookObject3.Title);

			Console.ReadLine();
		}
	}
}
