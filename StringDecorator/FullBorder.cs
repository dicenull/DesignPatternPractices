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
			if(row == 0)
			{
				return "+" + makeLine('-', display.Columns) + "+";
			}
			else if(row == display.Rows + 1)
			{
				return "+" + makeLine('-', display.Columns) + "+";
			}
			else
			{
				return "|" + display.GetRowText(row - 1) + "|";
			}
		}

		private string makeLine(char ch, int count)
		{
			var builder = new StringBuilder();

			for (var i = 0; i < count; i++)
			{
				builder.Append(ch);
			}

			return builder.ToString();
		}
	}
}
