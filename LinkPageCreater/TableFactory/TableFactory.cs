using LinkPageCreater.AbsFactory;

namespace LinkPageCreater.TableFactory
{
	public class TableFactory : Factory
	{
		public override Link CreateLink(string caption, string url)
		{
			return new TableLink(caption, url);
		}

		public override Page CreatePage(string title, string author)
		{
			return new TablePage(title, author);
		}

		public override Tray CreateTray(string caption)
		{
			return new TableTray(caption);
		}
	}
}
