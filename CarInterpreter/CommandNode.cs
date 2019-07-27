using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class CommandNode : Node
	{
		private Node node;

		public override void Parse(Context context)
		{
			if(context.CurrentToken == "repeat")
			{
				node = new RepeatCommandNode();
			}
			else
			{
				node = new PrimitiveCommandNode();
			}

			node.Parse(context);
		}

		public override string ToString()
		{
			return node.ToString();
		}
	}
}
