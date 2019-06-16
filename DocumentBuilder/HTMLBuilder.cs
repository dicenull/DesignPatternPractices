using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentBuilder
{
	class HTMLBuilder : Builder
	{
		private string filename;
		private StreamWriter writer;


		protected override void buildTitle(string title)
		{
			filename = $"{title}.html";

			writer = File.CreateText(filename);
			writer.WriteLine($"<html><head><title>{title}</title></head></body>");
			writer.WriteLine($"<h1>{title}</h1>");
		}
		protected override void buildString(string str)
		{
			writer.WriteLine($"<p>{str}</p>");
		}
		protected override void buildItems(IEnumerable<string> items)
		{
			writer.WriteLine("<ul>");
			foreach(var item in items)
			{
				writer.WriteLine($"<li>{item}</li>");
			}
			writer.WriteLine("</ul>");
		}

		protected override void done()
		{
			writer.WriteLine("</body></html>");
			writer.Close();
		}

		public string GetResult()
		{
			return filename;
		}
	}
}
