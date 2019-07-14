using System;
using LinkPageCreater.AbsFactory;

namespace LinkPageCreater
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Factory name>");
			var name = Console.ReadLine();

			var factory = Factory.GetFactory(Type.GetType("LinkPageCreater.ListFactory." + name));

			Link asahi = factory.CreateLink("朝日", "http://www.asahi.com/");
			Link yomiuri = factory.CreateLink("読売", "http://yomiuri.co.jp/");

			Link us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
			Link jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp");

			Link excite = factory.CreateLink("Excite", "http://www.excite.com/");
			Link google = factory.CreateLink("Google", "http://www.google.com/");

			Tray trayNews = factory.CreateTray("新聞");
			trayNews.Add(asahi);
			trayNews.Add(yomiuri);

			Tray trayYahoo = factory.CreateTray("Yahoo!");
			trayYahoo.Add(us_yahoo);
			trayYahoo.Add(jp_yahoo);

			Tray traySearch = factory.CreateTray("サーチエンジン");
			traySearch.Add(trayYahoo);
			traySearch.Add(excite);
			traySearch.Add(google);

			Page page = factory.CreatePage("LinkPage", "Dice");
			page.Add(trayNews);
			page.Add(traySearch);
			page.Output();
		}
	}
}
