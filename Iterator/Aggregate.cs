using System;
using System.Collections.Generic;
using System.Text;

namespace No0101
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
