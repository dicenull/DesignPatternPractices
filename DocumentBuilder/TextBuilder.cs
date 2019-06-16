using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	class TextBuilder : Builder
	{
		StringBuilder strBuilder = new StringBuilder();

		public void MakeTitle(string title)
		{
			appendDecoLine();
			strBuilder.Append($"[{title}]\n\n");
		}

		public void MakeString(string str)
		{
			strBuilder.Append($"■{str}\n\n");
		}

		public void MakeItems(IEnumerable<string> items)
		{
			foreach(var item in items)
			{
				strBuilder.Append($"　・{item}\n");
			}
			strBuilder.Append("\n");
		}

		public void Close()
		{
			appendDecoLine();
		}

		private void appendDecoLine()
		{
			strBuilder.Append('=', 30);
			strBuilder.AppendLine();
		}

		public string GetResult()
		{
			return strBuilder.ToString();
		}
	}
}
