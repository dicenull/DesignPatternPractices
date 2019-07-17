using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public class ListVisitor : Visitor
	{
		private string currentDir = "";

		public void Visit(File file)
		{
			Console.WriteLine($"{currentDir}/{file}");
		}

		public void Visit(Directory directory)
		{
			Console.WriteLine($"{currentDir}/{directory}");

			var saveDir = currentDir;

			currentDir = currentDir + "/" + directory.Name;
			foreach(var entry in directory.GetIterator())
			{
				entry.Accept(this);
			}

			currentDir = saveDir;
		}
	}
}
