using System.Drawing;

namespace CommandPainter
{
	public interface Drawable
	{
		void Draw(int x, int y);
		void ChangeColor(Color color);
	}
}
