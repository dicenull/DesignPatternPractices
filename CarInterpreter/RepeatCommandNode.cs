using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class RepeatCommandNode : Node
	{
		private int number;
		private Node commandListNode;

		public override void Parse(Context context)
		{
			context.SkipToken("repeat");

			number = context.CurrentNumber;
			context.NextToken();

			commandListNode = new CommandListNode();


			commandListNode.Parse(context);
		}

		public override string ToString()
		{
			return $"[repeat {number} {commandListNode}]"; 
		}
	}
}
