using System;

namespace EntryVisitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Making root entries...");

			var rootDir = new Directory("root");
			var binDir = new Directory("bin");
			var tmpDir = new Directory("tmp");
			var usrDir = new Directory("usr");

			rootDir.Add(binDir);
			rootDir.Add(tmpDir);
			rootDir.Add(usrDir);

			binDir.Add(new File("vi", 10000));
			binDir.Add(new File("latex", 20000));

			rootDir.Accept(new ListVisitor());

			Console.WriteLine();
			Console.WriteLine("Making user entries...");

			var yuki = new Directory("yuki");
			var hanako = new Directory("hanako");
			var tomura = new Directory("tomura");
			usrDir.Add(yuki);
			usrDir.Add(hanako);
			usrDir.Add(tomura);

			yuki.Add(new File("diary.html", 100));
			yuki.Add(new File("Composite.java", 200));
			hanako.Add(new File("index.html", 350));
			hanako.Add(new File("memo.tex", 300));
			tomura.Add(new File("game.doc", 400));
			tomura.Add(new File("junk.mail", 500));

			rootDir.Accept(new ListVisitor());

			var ffv = new FileFindVisitor(".html");
			rootDir.Accept(ffv);

			foreach(var file in ffv.FoundFiles)
			{
				Console.WriteLine(file.ToString());
			}
		}
	}
}
