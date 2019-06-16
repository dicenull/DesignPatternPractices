using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	class TextBuilder : Builder
	{
		StringBuilder strBuilder = new StringBuilder();

		protected override void buildTitle(string title)
		{
			appendDecoLine();
			strBuilder.Append($"[{title}]\n\n");
		}

		protected override void buildString(string str)
		{
			strBuilder.Append($"■{str}\n\n");
		}

		protected override void buildItems(IEnumerable<string> items)
		{
			foreach(var item in items)
			{
				strBuilder.Append($"　・{item}\n");
			}
			strBuilder.Append("\n");
		}

		protected override void done()
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
