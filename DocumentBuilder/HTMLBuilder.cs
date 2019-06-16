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


		public void MakeTitle(string title)
		{
			filename = $"{title}.html";

			writer = File.CreateText(filename);
			writer.WriteLine($"<html><head><title>{title}</title></head></body>");
			writer.WriteLine($"<h1>{title}</h1>");
		}
		public void MakeString(string str)
		{
			writer.WriteLine($"<p>{str}</p>");
		}
		public void MakeItems(IEnumerable<string> items)
		{
			writer.WriteLine("<ul>");
			foreach(var item in items)
			{
				writer.WriteLine($"<li>{item}</li>");
			}
			writer.WriteLine("</ul>");
		}

		public void Close()
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
