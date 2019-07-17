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

			// Shift_JISを登録
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		}

		public override int Columns
		{
			// 2byte文字でも幅が合うようにバイト数を取得する
			get => Encoding.GetEncoding("shift-jis").GetByteCount(str);
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
