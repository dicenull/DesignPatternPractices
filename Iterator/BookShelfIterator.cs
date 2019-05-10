namespace IteratorPatternBookShelf
{
	class BookShelfIterator : Iterator<Book>
	{
		private BookShelf bookShelf;
		private int index;

		public BookShelfIterator(BookShelf bookShelf)
		{
			this.bookShelf = bookShelf;
			index = 0;
		}

		public bool HasNext()
		{
			return (index < bookShelf.Lengh);
		}

		public Book Next()
		{
			var book = bookShelf.GetLookAt(index);
			index++;

			return book;
		}
	}
}