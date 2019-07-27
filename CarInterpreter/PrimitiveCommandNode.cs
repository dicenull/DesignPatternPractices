using System;
using System.Collections.Generic;
using System.Text;

namespace CarInterpreter
{
	public class PrimitiveCommandNode : Node
	{
		private string name;
		public override void Parse(Context context)
		{
			name = context.CurrentToken;

			context.SkipToken(name);

			if(    !(name == "go")
				&& !(name == "right")
				&& !(name == "left"))
			{
				throw new ParseException(name + "is undefined");
			}
		}

		public override string ToString()
		{
			return name;
		}
	}
}
