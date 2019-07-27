using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPainter
{
	public class MacroCommand : ICommand
	{
		private Stack<ICommand> commands = new Stack<ICommand>();

		public void Execute()
		{
			foreach(var command in commands.Reverse())
			{
				command.Execute();
			}
		}

		public void Append(ICommand cmd)
		{
			if(cmd != this)
			{
				commands.Push(cmd);
			}
		}

		public void Undo()
		{
			if(commands.Count != 0)
			{
				commands.Pop();
			}
		}

		public void Clear()
		{
			commands.Clear();
		}
	}
}
