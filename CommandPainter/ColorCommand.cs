using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPainter
{
	public class ColorCommand : ICommand
	{
		private Color color;
		private Drawable drawable; 

		public ColorCommand(Drawable drawable, Color color)
		{
			this.drawable = drawable;
			this.color = color;
		}

		public void Execute()
		{
			drawable.ChangeColor(color);
		}
	}
}
