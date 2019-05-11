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

		protected override void Open()
		{
			Console.Write("<<");
		}

		protected override void Print()
		{
			Console.Write(ch);
		}

		protected override void Close()
		{
			Console.WriteLine(">>");
		}
	}
}
