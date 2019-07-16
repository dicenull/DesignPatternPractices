using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompositeDirectory
{
	public abstract class Entry
	{
		public virtual string Name { get; protected set; }

		public virtual int Size { get; protected set; }

		public virtual Entry Add(Entry entry)
		{
			throw new FileTreatmentException();
		}

		public virtual void PrintList()
		{
			printList("");
		}

		protected internal abstract void printList(string prefix);

		public override string ToString()
		{
			return $"{Name} ({Size})";
		}

		protected internal Entry parent = null;

		public string FullName
		{
			get
			{
				string name = "";

				var entry = this;
				while(entry != null)
				{
					name = name.Insert(0, "/" + entry.Name);
					entry = entry.parent;
				}

				return name;
			}
		}
	}
}
