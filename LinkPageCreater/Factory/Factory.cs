using System;
using System.Collections.Generic;
using System.Text;

namespace LinkPageCreater.AbsFactory
{
	public abstract class Factory
	{
		public static Factory GetFactory(Type classType)
		{
			var factory = (Factory)Activator.CreateInstance(classType);

			return factory;
		}

		public abstract Link CreateLink(string caption, string url);
		public abstract Tray CreateTray(string caption);
		public abstract Page CreatePage(string title, string author);

		public Page CreateYahooPage()
		{
			var page = CreatePage("Yahoo!", "Yahoo!");
			page.Add(CreateLink("Yahoo!", "http://www.yahoo.com/"));

			return page;
		}
	}
}
