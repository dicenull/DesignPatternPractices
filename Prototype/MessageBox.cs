using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
	class MessageBox : Product
	{
		private char deco;

		public MessageBox(char decoChar)
		{
			this.deco = decoChar;
		}

		public override void Use(string s)
		{
			for(var i = 0;i < s.Length + 4;i++)
			{
				Console.Write(deco);
			}
			Console.WriteLine();

			Console.WriteLine($"{deco} {s} {deco}");

			for (var i = 0; i < s.Length + 4; i++)
			{
				Console.Write(deco);
			}
			Console.WriteLine();
		}
	}
}
