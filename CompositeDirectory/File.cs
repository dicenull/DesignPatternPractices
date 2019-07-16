using System;

namespace CompositeDirectory
{
	public class File : Entry
	{
		public File(string name, int size)
		{
			Name = name;
			Size = size;
		}

		protected internal override void printList(string prefix)
		{
			Console.WriteLine($"{prefix}/{this}");
		}
	}
}
