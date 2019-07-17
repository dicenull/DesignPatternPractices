using System;
using System.Collections.Generic;
using System.Text;

namespace StringDecorator
{
	public class SideBorder : Border
	{
		private char borderChar;

		public SideBorder(Display display, char ch)
			: base(display)
		{
			borderChar = ch;
		}

		public override int Columns
		{
			get => 1 + display.Columns + 1;
		}

		public override int Rows
		{
			get => display.Rows;
		}

		public override string GetRowText(int row)
		{
			return borderChar + display.GetRowText(row) + borderChar;
		}
	}
}
