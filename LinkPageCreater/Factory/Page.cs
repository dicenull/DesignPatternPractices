using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LinkPageCreater.AbsFactory
{
	public abstract class Page
	{
		protected string title;
		protected string author;
		protected List<Item> content = new List<Item>();

		public Page(string title, string author)
		{
			this.title = title;
			this.author = author;
		}

		public void Add(Item item)
		{
			content.Add(item);
		}

		public void Output()
		{
			var fileName = title + ".html";
			var writer = new StreamWriter(fileName);
			writer.Write(this.MakeHTML());
			writer.Close();

			Console.WriteLine($"{fileName}を作成しました");
		}

		public abstract string MakeHTML();
	}
}
