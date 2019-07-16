using System;
using System.Collections.Generic;
using System.Text;

namespace StringDecorator
{
	public class StringDisplay : Display
	{
		private string str;

		public StringDisplay(string str)
		{
			this.str = str;
		}

		public override int Columns
		{
			get => str.Length;
		}

		public override int Rows
		{
			get => 1;
		}

		public override string GetRowText(int row)
		{
			if(row == 0)
			{
				return str;
			}
			else
			{
				return null;
			}
		}
	}
}
