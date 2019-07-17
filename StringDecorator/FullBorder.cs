using System;
using System.Collections.Generic;
using System.Text;

namespace StringDecorator
{
	public class FullBorder : Border
	{
		public FullBorder(Display display)
			: base(display) { }

		public override int Columns
		{
			get => 1 + display.Columns + 1;
		}

		public override int Rows
		{
			get => 1 + display.Rows + 1;
		}

		public override string GetRowText(int row)
		{
			// 一番上か一番下
			if(row == 0 || row == display.Rows + 1)
			{
				return "+" + new string('-', display.Columns) + "+";
			}
			else
			{
				return "|" + display.GetRowText(row - 1) + "|";
			}
		}
	}
}
