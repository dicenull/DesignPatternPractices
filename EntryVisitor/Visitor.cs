using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public interface Visitor
	{
		void Visit(File file);
		void Visit(Directory directory);
	}
}
