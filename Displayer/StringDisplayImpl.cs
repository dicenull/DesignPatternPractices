using System;

namespace Displayer
{
	public class StringDisplayImpl : DisplayImpl
	{
		private string str;

		public StringDisplayImpl(string str)
		{
			this.str = str;
		}

		public override void RawOpen()
		{
			printLine();
		}

		public override void RawPrint()
		{
			Console.WriteLine($"|{str}|");
		}

		public override void RawClose()
		{
			printLine();
		}

		private void printLine()
		{
			Console.Write("+");
			for(var i = 0;i < str.Length;i++)
			{
				Console.Write("-");
			}
			Console.WriteLine("+");
		}
	}
}
