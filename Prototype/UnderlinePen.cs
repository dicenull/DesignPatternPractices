using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
	class UnderlinePen : Product
	{
		private char ulchar;

		public UnderlinePen(char ulchar)
		{
			this.ulchar = ulchar;
		}

		public object Clone()
		{
			return this;
		}

		public Product CreateClone()
		{
			return (Product)Clone();
		}

		public void Use(string s)
		{
			Console.WriteLine($"\"{s}\"");

			Console.Write(" ");
			for(var i = 0;i < s.Length;i++)
			{
				Console.Write(ulchar);
			}
			Console.WriteLine();
		}
	}
}
