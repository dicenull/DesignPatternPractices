using System;
using System.Collections.Generic;
using System.Text;

namespace No0101
{
	class Program
	{
		static void Main()
		{
			var bookShelf = new BookShelf();
			bookShelf.AppendBook(new Book("独習C#"));
			bookShelf.AppendBook(new Book("ロベールのC++入門"));
			bookShelf.AppendBook(new Book("Java言語で学ぶデザインパターン入門"));

			var iterator = bookShelf.Iterator();
			while (iterator.HasNext())
			{
				Console.WriteLine(iterator.Next().Name);
			}
		}
	}
}
