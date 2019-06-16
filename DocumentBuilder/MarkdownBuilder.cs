using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder
{
	class MarkdownBuilder : Builder
	{
		private StringBuilder strBuilder = new StringBuilder();

		protected override void buildTitle(string title)
		{
			strBuilder.AppendLine($"#{title}");
		}

		protected override void buildItems(IEnumerable<string> items)
		{
			foreach(var item in items)
			{
				strBuilder.AppendLine($"- {item}");
			}
		}

		protected override void buildString(string str)
		{
			strBuilder.AppendLine($"{str}  ");
		}

		protected override void done()
		{
		}

		public string GetResult()
		{
			return strBuilder.ToString();
		}
	}
}
