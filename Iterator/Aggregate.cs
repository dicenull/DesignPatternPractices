using System;
using System.Collections.Generic;
using System.Text;

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
