using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public class SizeVisitor : Visitor
	{
		public int SumSize { get; private set; } = 0;

		public void Visit(File file)
		{
			SumSize += file.Size;
		}

		public void Visit(Directory directory)
		{
			foreach(var entry in directory.GetIterator())
			{
				entry.Accept(this);
			}
		}
	}
}
