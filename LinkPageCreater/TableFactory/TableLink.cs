using LinkPageCreater.AbsFactory;

namespace LinkPageCreater.TableFactory
{
	public class TableLink : Link
	{
		public TableLink(string caption, string url)
			: base(caption, url) { }

		public override string MakeHTML()
		{
			return $"<td><a href=\"{url}\">{caption}</a></td>\n";
		}
	}
}
