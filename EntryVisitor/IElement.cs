using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public interface IElement
	{
		void Accept(Visitor v);
	}
}
