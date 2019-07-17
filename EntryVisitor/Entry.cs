using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public abstract class Entry : IElement
	{
		public virtual string Name { get; protected set; }

		public virtual int Size { get; protected set; }

		public abstract void Accept(Visitor v);

		public virtual Entry Add(Entry entry)
		{
			throw new FileTreatmentException();
		}

		public virtual IEnumerable<Entry> GetIterator()
		{
			throw new FileTreatmentException();
		}

		public override string ToString()
		{
			return $"{Name} ({Size})";
		}
	}
}
