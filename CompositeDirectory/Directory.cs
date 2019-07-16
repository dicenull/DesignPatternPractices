using System;
using System.Collections.Generic;

namespace CompositeDirectory
{
	public class Directory : Entry
	{
		private List<Entry> directory = new List<Entry>();

		public Directory(string name)
		{
			Name = name;
		}

		public override int Size
		{
			get
			{
				int size = 0;

				foreach(var entry in directory)
				{
					size += entry.Size;
				}

				return size;
			}
		}

		public override Entry Add(Entry entry)
		{
			directory.Add(entry);

			entry.parent = this;

			return this;
		}

		protected internal override void printList(string prefix)
		{
			directory.ForEach(entry => entry.printList($"{prefix}/{Name}"));
		}
	}
}
