using System;
using System.Collections.Generic;
using System.Text;

namespace StringDecorator
{
	public class UpDownBorder : Border
	{
		private char borderCh;

		public UpDownBorder(Display display, char ch)
			: base(display)
		{
			borderCh = ch;
		}

		public override int Columns => display.Columns;

		public override int Rows => 1 + display.Rows + 1;

		public override string GetRowText(int row)
		{
			// 一番上か一番下
			if (row == 0 || row == display.Rows + 1)
			{
				return new string(borderCh, display.Columns);
			}
			else
			{
				return display.GetRowText(row - 1);
			}
		}
	}
}
