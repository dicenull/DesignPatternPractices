using System;
using System.Collections.Generic;
using System.Text;

namespace EntryVisitor
{
	public class FileFindVisitor : Visitor
	{
		private string ext;
		private List<File> files = new List<File>();

		public FileFindVisitor(string ext)
		{
			this.ext = ext;
		}

		public IEnumerable<File> FoundFiles => files;

		public void Visit(File file)
		{
			if(file.Name.Contains(ext))
			{
				files.Add(file);
			}
		}

		public void Visit(Directory directory)
		{
			foreach(var entry in directory.GetIterator())
			{
				entry.Accept(this);
			}
		}
	}
}
