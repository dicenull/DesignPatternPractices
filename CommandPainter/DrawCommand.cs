using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommandPainter
{
	public class DrawCommand : ICommand
	{
		protected Drawable drawable;

		private Point position;

		public DrawCommand(Drawable drawable, Point position)
		{
			this.drawable = drawable;
			this.position = position;
		}

		public void Execute()
		{
			drawable.Draw(position.X, position.Y);
		}
	}
}
