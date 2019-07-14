using LinkPageCreater.AbsFactory;
using System.Text;

namespace LinkPageCreater.TableFactory
{
	public class TablePage : Page
	{
		public TablePage(string title, string author)
			: base(title, author) { }

		public override string MakeHTML()
		{
			var strBuilder = new StringBuilder();

			strBuilder
				.Append($"<html><head><title>{title}</title></head>\n")
				.Append("<body>\n")
				.Append($"<h1>{title}</h1>\n")
				.Append("<table width=\"80%\" border=\"3\">\n");

			foreach(var item in content)
			{
				strBuilder.Append($"<tr>{item.MakeHTML()}</tr>");
			}

			strBuilder
				.Append("</table>\n")
				.Append($"<hr><address>{author}</address>")
				.Append("</body></html>\n");

			return strBuilder.ToString();
		}
	}
}
