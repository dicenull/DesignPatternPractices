using System;

namespace DocumentBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("plain or html or md>");
			var str = Console.ReadLine();

			var builder = str switch
			{
				"plain" => (Builder)new TextBuilder(),
				"html" => (Builder)new HTMLBuilder(),
				"md" => (Builder)new MarkdownBuilder(),
				_ => throw new InvalidOperationException()
			};

			var director = new Director(builder);
			director.Construct();

			if (builder is TextBuilder)
			{
				var result = (builder as TextBuilder).GetResult();

				Console.WriteLine(result);
			}
			else if (builder is HTMLBuilder)
			{
				var filename = (builder as HTMLBuilder).GetResult();

				Console.WriteLine($"{filename}が作成されました");
			}
			else if (builder is MarkdownBuilder)
			{
				var result = (builder as MarkdownBuilder).GetResult();

				Console.WriteLine(result);
			}

		}
	}
}
