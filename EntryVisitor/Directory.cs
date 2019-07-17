using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntryVisitor
{
	public class Directory : Entry
	{
		private List<Entry> dir = new List<Entry>();

		public override int Size
		{
			get
			{
				return dir.Sum(entry => entry.Size);
			}
		}

		public Directory(string name)
		{
			Name = name;
		}

		public override Entry Add(Entry entry)
		{
			dir.Add(entry);

			return this;
		}

		public override IEnumerable<Entry> GetIterator()
		{
			return dir;
		}

		public override void Accept(Visitor v)
		{
			v.Visit(this);
		}
	}
}
