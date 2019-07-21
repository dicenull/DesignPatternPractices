using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PageFacade
{
	public static class PageMaker
	{
		public static void MakeWelcomePage(string mailAdder, string fileName)
		{
			var mailProp = Database.GetProperties("maildata");
			var userName = mailProp.GetProperties(mailAdder);

			var writer = new HtmlWriter(new StreamWriter(fileName));

			writer.Title($"Welcome to {userName}'s page!");
			writer.Paragraph($"{userName} のページへようこそ。");
			writer.Paragraph(">>> MAIL <<<");
			writer.MailTo(mailAdder, userName);
			writer.Close();

			Console.WriteLine($"{fileName} is created for {mailAdder} ({userName})");
		}

		public static void MakeLinkPage(string fileName)
		{
			var mails = Database.GetProperties("maildata");
			var writer = new HtmlWriter(new StreamWriter(fileName));

			writer.Title("Link Page");
			foreach(var mail in mails.GetProperties())
			{
				writer.Link(mail.Key, mail.Value);
			}
			writer.Close();

			Console.WriteLine($"{fileName} is created.");
		}
	}
}
