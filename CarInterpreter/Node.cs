using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public abstract class Node
	{
		public abstract void Parse(Context context);
	}
}
