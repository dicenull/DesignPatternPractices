
using LinkPageCreater.AbsFactory;
using System.Text;

namespace LinkPageCreater.ListFactory
{
	public class ListPage : Page
	{
		public ListPage(string title, string author)
			: base(title, author) { }

		public override string MakeHTML()
		{
			var strBuilder = new StringBuilder();

			strBuilder
				.AppendLine($"<html><head><title>{title}</title></head>")
				.AppendLine("<body>")
				.AppendLine($"<h1>{title}</h1>");

			strBuilder.AppendLine("<ul>");
			foreach (var item in content)
			{
				strBuilder.Append(item.MakeHTML());
			}
			strBuilder.AppendLine("</ul>");

			strBuilder.AppendLine($"<hr><address>{author}</address>");
			strBuilder.AppendLine("</body></html>");

			return strBuilder.ToString();
		}
	}
}
