using System.Collections.Generic;

namespace IteratorPatternBookShelf
{
	class BookShelf : Aggregate<Book>
	{
		private List<Book> books;
		
		public int Lengh { get { return books.Count; } }

		public BookShelf()
		{
			books = new List<Book>();
		}

		public Book GetLookAt(int index)
		{
			return books[index];
		}

		public void AppendBook(Book book)
		{
			books.Add(book);
		}

		public Iterator<Book> Iterator()
		{
			return new BookShelfIterator(this);
		}
	}
}
