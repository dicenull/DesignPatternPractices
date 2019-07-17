using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringDecorator
{
	public class MultiStringDisplay : Display
	{
		private List<string> strList = new List<string>();
		private Encoding encoding = Encoding.GetEncoding("shift-jis");


		public override int Columns => strList.Max(str => encoding.GetByteCount(str));

		public override int Rows => strList.Count;

		public override string GetRowText(int row)
		{
			var rowStr = strList[row];

			// マルチバイトの場合に発生するずれを補正する
			var dev = encoding.GetByteCount(rowStr) - rowStr.Length;

			return strList[row].PadRight(Columns - dev);
		}

		public void Add(string str)
		{
			strList.Add(str);
		}
	}
}
