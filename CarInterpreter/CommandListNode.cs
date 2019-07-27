using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class CommandListNode : Node
	{
		private List<Node> list = new List<Node>();

		public override void Parse(Context context)
		{
			while(true)
			{
				if(context.CurrentToken == null)
				{
					throw new ParseException("Missing 'end'");
				}

				if(context.CurrentToken == "end")
				{
					context.SkipToken("end");
					break;
				}
				else
				{
					var commandNode = new CommandNode();
					commandNode.Parse(context);

					list.Add(commandNode);
				}
			}
		}

		public override string ToString()
		{
			string str = "[";
			for(var i = 0;i < list.Count;i++)
			{
				str += list[i].ToString();

				if(i == list.Count - 1)
				{
					str += "]";
				}
				else
				{
					str += ", ";
				}
			}
			
			return str;
		}
	}
}
