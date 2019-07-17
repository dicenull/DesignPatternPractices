using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public class File : Entry
	{
		public File(string name, int size)
		{
			Name = name;
			Size = size;
		}

		public override void Accept(Visitor v)
		{
			v.Visit(this);
		}
	}
}
