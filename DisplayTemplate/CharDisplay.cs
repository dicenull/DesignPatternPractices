using System;

namespace DisplayTemplate
{
	class CharDisplay : DisplayBase
	{
		private char ch;

		public CharDisplay(char ch)
		{
			this.ch = ch;
		}

		public override void Open()
		{
			Console.Write("<<");
		}

		public override void Print()
		{
			Console.Write(ch);
		}

		public override void Close()
		{
			Console.WriteLine(">>");
		}
	}
}
