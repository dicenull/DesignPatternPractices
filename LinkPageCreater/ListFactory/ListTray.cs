using LinkPageCreater.AbsFactory;
using System.Text;

namespace LinkPageCreater.ListFactory
{
	public class ListTray : Tray
	{
		public ListTray(string caption)
			: base(caption){ }

		public override string MakeHTML()
		{
			var strBuilder = new StringBuilder();

			strBuilder
				.AppendLine("<li>")
				.AppendLine($"{caption}")
				.AppendLine("<ul>");

			foreach(var item in tray)
			{
				strBuilder.Append(item.MakeHTML());
			}

			strBuilder.AppendLine("</ul>");
			strBuilder.AppendLine("</li>");

			return strBuilder.ToString();
		}
	}
}
