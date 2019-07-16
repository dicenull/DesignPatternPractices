using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompositeDirectory
{
	public abstract class Entry
	{
		public abstract string Name { get; }

		public abstract int Size { get; }

		public virtual Entry Add(Entry entry)
		{
			throw new FileTreatmentException();
		}

		public void PrintList()
		{
			PrintList("");
		}

		public abstract void PrintList(string prefix);

		public override string ToString()
		{
			return $"{Name} ({Size})";
		}
	}
}
