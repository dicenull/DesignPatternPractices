using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPainter
{
	public partial class Form1 : Form
	{
		private MacroCommand history = new MacroCommand();

		private DrawCanvas canvas;

		public Form1()
		{
			InitializeComponent();

			initCanvas();
		}

		private void initCanvas()
		{
			pictureBoxCanvas.Image = new Bitmap(400, 400);
			canvas = new DrawCanvas(pictureBoxCanvas.Image, history);
		}

		private void ButtonClear_Click(object sender, EventArgs e)
		{
			history.Clear();

			initCanvas();
			pictureBoxCanvas.Refresh();
		}

		private void PictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button.HasFlag(MouseButtons.Left))
			{
				var cmd = new DrawCommand(canvas, e.Location);
				history.Append(cmd);

				cmd.Execute();
				pictureBoxCanvas.Refresh();
			}
		}

		private void ButtonRed_Click(object sender, EventArgs e)
		{
			colorChangeExe(Color.Red);
		}

		private void ButtonGreen_Click(object sender, EventArgs e)
		{
			colorChangeExe(Color.Green);
		}

		private void ButtonBlue_Click(object sender, EventArgs e)
		{
			colorChangeExe(Color.Blue);
		}

		private void colorChangeExe(Color color)
		{
			var cmd = new ColorCommand(canvas, color);
			history.Append(cmd);

			cmd.Execute();
			pictureBoxCanvas.Refresh();
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			history.Undo();

			canvas.RePaint();
			pictureBoxCanvas.Refresh();
		}
	}
}
