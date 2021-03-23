using System;

namespace UseStruct.Folder
{
	struct Book
	{
		public string Author;
		public string Title;
		public int Copyright;

		public Book(string nameAuthor, string nameBook, int year)
		{
			Author = nameAuthor;
			Title = nameBook;
			Copyright = year;
		}
	}
}
