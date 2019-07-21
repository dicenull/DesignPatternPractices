using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PageFacade
{
	public class HtmlWriter
	{
		private TextWriter writer;

		public HtmlWriter(TextWriter writer)
		{
			this.writer = writer;
		}

		public void Title(string title)
		{
			writer.Write("<html>");
			writer.Write("<head>");
			writer.Write($"<title>{title}</title>");
			writer.Write("</head>");
			writer.Write("<body>\n");
			writer.Write($"<h1>{title}</h1>\n");
		}

		public void Paragraph(string msg)
		{
			writer.Write($"<p>{msg}</p>\n");
		}

		public void Link(string href, string caption)
		{
			Paragraph($"<a href=\"{href}\"> {caption} </a>");
		}

		public void MailTo(string mailAdder, string username)
		{
			Link($"mailto: {mailAdder}", username);
		}

		public void Close()
		{
			writer.Write("</body>");
			writer.Write("</html>\n");
			writer.Close();
		}
	}
}
