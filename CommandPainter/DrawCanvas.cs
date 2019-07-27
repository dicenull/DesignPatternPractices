using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPainter
{
	public class DrawCanvas : Drawable
	{
		private Color color = Color.Red;
		private Graphics g;
		
		private int radius = 6;

		private MacroCommand history;

		public DrawCanvas(Image image, MacroCommand history)
		{
			g = Graphics.FromImage(image);

			this.history = history;

			history.Append(new ColorCommand(this, color));
		}

		public void RePaint()
		{
			g.FillRectangle(new SolidBrush(Color.White), g.ClipBounds);
			history.Execute();
		}

		public void Draw(int x, int y)
		{
			g.FillEllipse(new SolidBrush(color), x - radius, y - radius, radius * 2, radius * 2);
		}

		public void ChangeColor(Color color)
		{
			this.color = color;
		}
	}
}
