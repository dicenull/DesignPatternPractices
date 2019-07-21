using System;
using System.Collections.Generic;
using System.Text;

namespace TroubleChain
{
	public class Trouble
	{
		public int Number { get; }

		public Trouble(int number)
		{
			Number = number;
		}

		public override string ToString()
		{
			return $"[Trouble {Number}]";
		}
	}
}
