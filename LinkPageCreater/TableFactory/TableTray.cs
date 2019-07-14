using System.Text;
using LinkPageCreater.AbsFactory;

namespace LinkPageCreater.TableFactory
{
	public class TableTray : Tray
	{
		public TableTray(string caption)
			: base(caption) { }

		public override string MakeHTML()
		{
			var strBuilder = new StringBuilder();

			strBuilder
				.Append("<td>")
				.Append("<table width=\"100%\" border=\"1\"> <tr>")
				.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{tray.Count}\"><b>{caption}</b></td>")
				.Append("</tr>\n")
				.Append("<tr>\n");

			foreach(var item in tray)
			{
				strBuilder.Append(item.MakeHTML());
			}

			strBuilder.Append("</tr></table>");
			strBuilder.Append("</td>");

			return strBuilder.ToString();

		}
	}
}
