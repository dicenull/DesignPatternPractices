using System;
using System.Collections.Generic;
using System.Text;

namespace DisplayTemplate
{
	class StringDisplay : DisplayBase
	{
		private string str;
		private int width;

		public StringDisplay(string str)
		{
			this.str = str;
			width = Encoding.UTF8.GetBytes(str).Length;
		}

		public override void Open()
		{
			printLine();
		}

		public override void Print()
		{
			Console.WriteLine($"|{str}|");
		}

		public override void Close()
		{
			printLine();
		}

		private void printLine()
		{
			Console.Write("+");

			for(var i = 0;i < width;i++)
			{
				Console.Write("-");
			}

			Console.WriteLine("+");
		}
	}
}
