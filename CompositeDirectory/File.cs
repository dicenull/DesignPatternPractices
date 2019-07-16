using System;

namespace CompositeDirectory
{
	public class File : Entry
	{
		private string name;
		private int size;

		public File(string name, int size)
		{
			this.name = name;
			this.size = size;
		}

		public override string Name => name;

		public override int Size => size;

		public override void PrintList(string prefix)
		{
			Console.WriteLine($"{prefix}/{this}");
		}
	}
}
