using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	class ProgramNode : Node
	{
		private Node commandListNode;

		public override void Parse(Context context)
		{
			context.SkipToken("program");

			commandListNode = new CommandListNode();
			commandListNode.Parse(context);
		}

		public override string ToString()
		{
			return "[program " + commandListNode + "]";
		}
	}
}
