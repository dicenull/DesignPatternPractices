using System;

namespace Displayer
{
	public class CharDisplayImpl : DisplayImpl
	{
		char start, body, end;

		public CharDisplayImpl(char start, char body, char end)
		{
			this.start = start;
			this.body = body;
			this.end = end;
		}

		public override void RawOpen()
		{
			Console.Write(start);
		}

		public override void RawPrint()
		{
			Console.Write(body);
		}

		public override void RawClose()
		{
			Console.WriteLine(end);
		}

	}
}
