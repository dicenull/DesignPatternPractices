namespace IteratorPatternBookShelf
{
	interface Aggregate<T>
	{
		Iterator<T> Iterator(); 
	}

	interface Iterator<T>
	{
		bool HasNext();

		T Next();
	}
}
