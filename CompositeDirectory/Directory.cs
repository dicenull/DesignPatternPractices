using System;
using System.Collections.Generic;

namespace CompositeDirectory
{
	public class Directory : Entry
	{
		private string name;
		private List<Entry> directory = new List<Entry>();

		public Directory(string name)
		{
			this.name = name;
		}

		public override string Name => name;

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

			return this;
		}

		public override void PrintList(string prefix)
		{
			Console.WriteLine($"{prefix}/{this}");

			foreach(var entry in directory)
			{
				entry.PrintList($"{prefix}/{Name}");
			}
		}
	}
}
